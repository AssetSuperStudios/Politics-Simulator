using UnityEngine;
using System.Collections.Generic;

public class GameActionsManager : MonoBehaviour
{
    [SerializeField] private Data playerData;
    [SerializeField] private CharacterStats selectedCharacter;
    [SerializeField] private Actions actionsReference;
    [SerializeField] private UpdateData updateData;
    public CalendarTick calendarTick;

    private List<GameAction> tempList = new List<GameAction>();
    private float lastExecutionTime = 0f;
    [SerializeField] private float spamCooldown = 0.25f;
    private int lastExecutionFrame = -1;

    void Awake()
    {
        InitializeActions();
    }

    public void InitializeActions()
    {
        tempList.Clear();

        AddAction("Hire Police",        "hire_police",      25,    5,     -10,   5,  "Hire police to increase safety.");
        AddAction("Police Sports Fest", "build_farm",   15,    10,    -8,    10, "Organize a sports festival to boost morale and safety.");
        AddAction("Bribe Locals",       "bribe_locals",    -10,    20,    -10,   10, "Bribe locals to increase influence.");
        AddAction("Road Repairs",       "road_repair",     -10,   -10,     75,   5,  "Repair roads to improve safety.");
        AddAction("Charity Event",      "tandem_riding",  -5,     5,      50,   10, "Organize a charity event to boost morale and influence.");
        AddAction("Local Sweepstakes",  "build_wall",  -10,   -25,     100,  5,  "Host a local sweepstakes.");

        promotedActions();

        actionsReference.ActionList = tempList;
    }

    private void AddAction(string name, string sprite, int mil, int inf, int mon, int time, string desc)
    {
        GameAction act = new GameAction
        {
            actionName = name,
            actionSpritePath = sprite,
            resourceMilitary = mil,
            resourceInfluence = inf,
            resourceMoney = mon,
            resourceTime = time,
            actionDescription = desc
        };

        act.actionFunctionCall = () => ExecuteActionPipeline(act);
        tempList.Add(act);
    }

    private bool ExecuteActionPipeline(GameAction action)
    {
        if (Time.frameCount == lastExecutionFrame)
        {
            Debug.LogWarning("Action submission dropped: Blocked identical frame execution twin.");
            return false;
        }
        if (Time.time < lastExecutionTime + spamCooldown)
        {
            Debug.LogWarning("Action submission dropped: Input spam tracking filter triggered.");
            return false;
        }

        if ((action.resourceMilitary < 0 && playerData.MilitaryValue < Mathf.Abs(action.resourceMilitary)) ||
            (action.resourceInfluence < 0 && playerData.InfluenceValue < Mathf.Abs(action.resourceInfluence)) ||
            (action.resourceMoney < 0 && playerData.MoneyValue < Mathf.Abs(action.resourceMoney)))
        {
            Debug.LogWarning($"Cannot execute {action.actionName}: Insufficient resources available!");
            return false;
        }

        lastExecutionFrame = Time.frameCount;
        lastExecutionTime = Time.time;

        Debug.Log($"Executing action: {action.actionName}...");

        float moneyCharMultiplier = selectedCharacter.percentageMoneyModifier;
        float militaryCharMultiplier = selectedCharacter.percentageMilitaryModifier;
        float influenceCharMultiplier = selectedCharacter.percentageInfluenceModifier;

        // Adjust character modifier to invert when negative changes
        float finalMoneyChange = action.resourceMoney >= 0
        ? action.resourceMoney * moneyCharMultiplier
        : action.resourceMoney * (2f - moneyCharMultiplier);
        float finalMilitaryChange = action.resourceMilitary >= 0
        ? action.resourceMilitary * militaryCharMultiplier
        : action.resourceMilitary * (2f - militaryCharMultiplier);
        float finalInfluenceChange = action.resourceInfluence >= 0
        ? action.resourceInfluence * influenceCharMultiplier
        : action.resourceInfluence * (2f - influenceCharMultiplier);

        playerData.MoneyValue = Mathf.Max(0, playerData.MoneyValue + Mathf.RoundToInt(finalMoneyChange));
        playerData.MilitaryValue = Mathf.Max(0, playerData.MilitaryValue + Mathf.RoundToInt(finalMilitaryChange));
        playerData.InfluenceValue = Mathf.Min(Mathf.Max(0, playerData.InfluenceValue + Mathf.RoundToInt(finalInfluenceChange)), DataTracker.maxInfluence);

        if (calendarTick != null)
        {
            calendarTick.DayPassed(action.resourceTime);
        }
        else
        {
            Debug.LogError("CalendarTick runtime script instance reference missing from inspector slot!");
        }

        updateData.newUpdateData(new Updates
        {
           updateDescription = "Successful action!",
           updateSpritePath = action.actionSpritePath,
           updateFlavorText = action.actionDescription 
        });

        return true;
    }

    public void promotedActions()
    {
        switch (playerData.ClassName)
        {
            case "President":
                AddAction("Drug Party",     "drug_party",     2500, -50,  -2000000,   30, "sniff sniff.");
                AddAction("War on Drugs",   "drug_war",      -2000,  350, -7000000,   10, "They are just collateral.");
                AddAction("Ghost Projects", "ghost_project", -300,  -250,  10000000,  10, "They say they still hear its whispers.");
                goto case "VP";

            case "VP":
                AddAction("Assassination Attempt",  "assassination",  2000,  -100,  -600000,  25, "It's a joke.");
                AddAction("Online Trolls",          "online_trolls", -1200,   300,  -300000,  25, "Is the internet dead?");
                AddAction("Confidential Funds",     "hide_overseas", -500,   -125,   1000000, 25, "Confidence sways the money over. Shh.");
                goto case "Senator";

            case "Senator":
                AddAction("Ex-marines",     "hire_soldiers", 1500, -50,  -80000,  20, "They have seen it all.");
                AddAction("People Power",   "start_trade",   -1000,  250, -10000,  20, "Nothing beats the people of power.");
                AddAction("Pork Barrel",    "pork_barrel",  -300,  -150,  100000, 20, "Real money stench.");
                AddAction("TV Dance",       "tv_dance",      50,    100,  10000,  25, "Show the real you.");
                goto case "Congress";

            case "Congress":
                AddAction("Military gifts",     "assign_workers",  800,  -25,  -600,  15, "Appreciate our protectors.");
                AddAction("Fake News Peddler",  "fake_news",      -350,   150, -300,  15, "Discombobulate.");
                AddAction("Suitcase",           "suitcase",       -350,  -100,  1000, 15, "Treasures are buried somewhere.");
                AddAction("Furry Convention",   "build_barracks", -200,   100,  500,  20, "Show a wilder different side of you.");
                goto case "Governor";

            case "Governor":
                AddAction("Military parade",      "build_mine",     100, -15,  -600,  10, "Show off how safe our land is.");
                AddAction("Tarpaulin",            "free_tarpaulin", -25,  50,  -300,  10, "Recognize achievers in your community.");
                AddAction("Underground Gambling", "upgrade_castle",  -60, -30,   1000, 10, "Provide chances for the downed.");
                AddAction("Adult Film",           "porn_movie",     -20,  30,   500,  15, "Show a different side of you.");
                break;

            default:
                Debug.Log("No further promotion available.");
                break;
        }
    }
}