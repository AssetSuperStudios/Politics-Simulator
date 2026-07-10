using UnityEngine;
using System.Collections.Generic;

public class CalendarTick : MonoBehaviour
{
    [SerializeField] private Data playerData;
    [SerializeField] private Data lastPlayerData;
    [SerializeField] private CharacterStats selectedCharacter;
    [SerializeField] private GameActionsManager gameActionsManager;
    private float timer;
    [SerializeField] private float tickInterval = 1.0f;
    public static bool isPaused = false;
    private int electionYearInterval = 5;
    private int electionWinCondition = (int)(0.75 * DataTracker.maxInfluence);

    [Header("Event System Settings")]
    [Range(0f, 100f)] [SerializeField] private float eventChancePerDay = 3f;
    [SerializeField] private List<GameEvent> possibleEvents = new List<GameEvent>();

    void Start()
    {
        isPaused = false;
        timer = 0f;
    }

    void Update()
    {
        if (isPaused) return;

        timer += Time.deltaTime;
        if (timer >= tickInterval)
        {
            timer -= tickInterval;
            DayPassed(1);
        }
    }

    public void DayPassed(int dayPassed)
    {
        bool eventTriggeredThisAction = false;

        for (int i = 0; i < dayPassed; i++)
        {
            playerData.TimeDay += 1;
            
            // Only roll a random event check if one hasn't fired yet during this timeline jump
            if (playerData.TimeDay > 90 && !eventTriggeredThisAction) 
            {
                // TryTriggerRandomEvent now returns a boolean telling us if something happened
                if (TryTriggerRandomEvent())
                {
                    eventTriggeredThisAction = true; 
                }
            }

            if (playerData.TimeDay % 360 == 0)
            {
                int currentYear = playerData.TimeDay / 360;
                if (currentYear % electionYearInterval == 0)
                {
                    startElection();
                }
            }
        }
    }

    private bool TryTriggerRandomEvent()
    {
        if (possibleEvents == null || possibleEvents.Count == 0) return false;

        if (Random.Range(0f, 100f) <= eventChancePerDay)
        {
            int randomIndex = Random.Range(0, possibleEvents.Count);
            ExecuteGameEvent(possibleEvents[randomIndex]);
            return true; // Confirms an event successfully fired
        }
        return false;
    }

    private void ExecuteGameEvent(GameEvent gEvent)
    {
        float moneyScale = 1f;
        float powerScale = 1f;

        switch (playerData.ClassName)
        {
            case "Mayor":
                moneyScale = 1f;       powerScale = 1.0f; 
                break;
            case "Governor":
                moneyScale = 10f;      powerScale = 1.2f; 
                break;
            case "Congress":
            case "Senator":
                moneyScale = 100f;     powerScale = 1.5f; 
                break;
            case "VP":
                moneyScale = 1000f;    powerScale = 1.8f; 
                break;
            case "President":
                moneyScale = 10000f;   powerScale = 2.0f; 
                break;
        }

        Debug.Log($"[EVENT] {gEvent.eventTitle} triggered for {playerData.ClassName}. Money Multiplier: {moneyScale}x, Power Multiplier: {powerScale}x");

        float moneyCharMultiplier       = selectedCharacter.percentageMoneyModifier;
        float militaryCharMultiplier    = selectedCharacter.percentageMilitaryModifier;
        float influenceCharMultiplier   = selectedCharacter.percentageInfluenceModifier;

        // Scale event changes with current class
        float moneyScaled      = Mathf.Abs(gEvent.moneyChange) * moneyScale;
        float militaryScaled   = Mathf.Abs(gEvent.militaryChange) * powerScale;
        float influenceScaled  = Mathf.Abs(gEvent.influenceChange) * powerScale;

        // Adjust character modifier to invert when negative changes
        float finalMoneyChange = moneyScaled >= 0
        ? moneyScaled * moneyCharMultiplier
        : moneyScaled * (2f - moneyCharMultiplier);
        float finalMilitaryChange = moneyScaled >= 0
        ? militaryScaled * militaryCharMultiplier
        : militaryScaled * (2f - militaryCharMultiplier);
        float finalInfluenceChange = moneyScaled >= 0
        ? influenceScaled * influenceCharMultiplier
        : influenceScaled * (2f - influenceCharMultiplier);

        // Make negative values 0
        playerData.MoneyValue = Mathf.Max(0, playerData.MoneyValue + Mathf.RoundToInt(finalMoneyChange));
        playerData.MilitaryValue = Mathf.Max(0, playerData.MilitaryValue + Mathf.RoundToInt(finalMilitaryChange));
        playerData.InfluenceValue = Mathf.Max(0, playerData.InfluenceValue + Mathf.RoundToInt(finalInfluenceChange));
    }

    public void startElection()
    {
        int currentYear = playerData.TimeDay / 360;
        Debug.Log("Election started! " + currentYear);
        isPaused = true;

        if (playerData.InfluenceValue < electionWinCondition)
        {
            Debug.Log("You lost the election due to low influence!");
            playerData.LoseStatus = 1;
            FindAnyObjectByType<GameCondition>().LoseCondition("election");
        }
        else
        {
            Debug.Log("You won the election!");
            classPromotion();
            savePlayerData();
            isPaused = false;
        }
    }

    void savePlayerData()
    {
        lastPlayerData.ClassName = playerData.ClassName;
        lastPlayerData.MoneyValue = playerData.MoneyValue;
        lastPlayerData.MilitaryValue = playerData.MilitaryValue;
        lastPlayerData.InfluenceValue = playerData.InfluenceValue;
        lastPlayerData.SatisfactionPercentage = playerData.SatisfactionPercentage;
        lastPlayerData.SafetyPercentage = playerData.SafetyPercentage;
        lastPlayerData.TimeDay = playerData.TimeDay;
        lastPlayerData.LoseStatus = 0;
        lastPlayerData.LocationIndex = playerData.LocationIndex;
        Debug.Log("Player data saved.");
    }

    void classPromotion()
    {
        switch (playerData.ClassName)
        {
            case "Mayor":
                playerData.ClassName = "Governor";
                break;
            case "Governor":
                playerData.ClassName = "Congress";
                break;
            case "Congress":
                playerData.ClassName = "Senator";
                break;
            case "Senator":
                playerData.ClassName = "VP";
                break;
            case "VP":
                playerData.ClassName = "President";
                break;
            default:
                Debug.Log("No further promotion available.");
                break;
        }
        gameActionsManager.InitializeActions();
    }
}
