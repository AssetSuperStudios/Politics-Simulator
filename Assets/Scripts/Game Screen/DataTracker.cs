// FRONT END

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
// Game Screen : CanvasGameScreen/DataHolder
// Attach this to the GameObject that holds the objects that track the game's main resources data

public class DataTracker : MonoBehaviour
{
    // Serialize Data Scriptable Object
    [SerializeField] private Data playerData;                   // Assets/Scripts/Scriptables/Data/PlayerData.cs
    // Serialize UI trackers
    [SerializeField] private TMP_Text classText;                // Game Screen : CanvasGameScreen/DataHolder/SafetyHolder/TextClass
    [SerializeField] private TMP_Text moneyText;                // Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/MoneyHolder/TextBoundingBox/TextMoneyValue
    [SerializeField] private TMP_Text militaryText;             // Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/MilitaryHolder/TextBoundingBox/TextMilitaryValue
    [SerializeField] private TMP_Text influenceText;            // Game Screen : CanvasGameScreen/DataHolder/ResourcesHolder/InfluenceHolder/TextBoundingBox/TextInfluenceValue
    [SerializeField] private Image satisfactionImage;           // Game Screen : CanvasGameScreen/DataHolder/SatisfactionHolder/ImageSatisfaction
    [SerializeField] private Image safetyImage;                 // Game Screen : CanvasGameScreen/DataHolder/SafetyHolder/ImageCharacter
    [SerializeField] private TMP_Text timeText;                 // Game Screen : CanvasGameScreen/DataHolder/CalendarHolder/TextTime
    [SerializeField] private TMP_Text yearText;                 // Game Screen : CanvasGameScreen/DataHolder/CalendarHolder/TextYear
    // Serialize CharacterStats
    [SerializeField] private CharacterStats selectedCharacter;  // Assets/Scripts/Scriptables/Data/SelectedCharacter.cs
    // Declare string and int used in the resource tracking
    private string safetySpritePath;
    [SerializeField] public static int maxInfluence = 680;
    [SerializeField] public static int daysInYear = 360;

    // Set the values on start
    // Calls MoneyChange(), MilitaryChange(), InfluenceChange(), SatisfactionChange(), SafetyChange(), TimeChange(), YearChange(), and LoseStatusChange()
    void Start()
    {
        // Initialize string path for Safety sprites after loading CharacterStats
        safetySpritePath = $"Sprites/Icons/Safety/{selectedCharacter.stringPath}";

        // Call each change manager and set its value
        ClassChange(playerData.ClassName);
        MoneyChange(playerData.MoneyValue);
        MilitaryChange(playerData.MilitaryValue);
        InfluenceChange(playerData.InfluenceValue);
        SatisfactionChange(playerData.SatisfactionPercentage);
        SafetyChange(playerData.SafetyPercentage);
        TimeChange(playerData.TimeDay);
        YearChange(playerData.TimeYear);
        LoseStatusChange(playerData.LoseStatus);
    }

    // Sets up OnValueChanged event listeners for all Data in the scene
    void OnEnable()
    {
        playerData.OnClassNameChanged += ClassChange;
        playerData.OnMoneyValueChanged += MoneyChange;
        playerData.OnMilitaryValueChanged += MilitaryChange;
        playerData.OnInfluenceValueChanged += InfluenceChange;
        playerData.OnSatisfactionPercentageChanged += SatisfactionChange;
        playerData.OnSafetyPercentageChanged += SafetyChange;
        playerData.OnTimeDayChanged += TimeChange;
        playerData.OnTimeYearChanged += YearChange;
        playerData.OnLoseStatusChanged += LoseStatusChange;
    }
    // Removes OnValueChanged event listeners for all Data in the scene
    void OnDisable()
    {
        playerData.OnClassNameChanged -= ClassChange;
        playerData.OnMoneyValueChanged -= MoneyChange;
        playerData.OnMilitaryValueChanged -= MilitaryChange;
        playerData.OnInfluenceValueChanged -= InfluenceChange;
        playerData.OnSatisfactionPercentageChanged -= SatisfactionChange;
        playerData.OnSafetyPercentageChanged -= SafetyChange;
        playerData.OnTimeDayChanged -= TimeChange;
        playerData.OnTimeYearChanged -= YearChange;
        playerData.OnLoseStatusChanged -= LoseStatusChange;
    }

    // Changes the class name, money value, military value, influence value, satisfaction value, safety value, day and year times, and the lose status
    // In that order
    void ClassChange(string newClassName)
    {
        classText.text = newClassName;
        Debug.Log($"Class Name changed to: {newClassName}");
    }
    void MoneyChange(int newMoneyValue)
    {
        moneyText.text = $"{newMoneyValue.ToString()} M";
        Debug.Log($"Money Value changed to: {newMoneyValue}");
    }

    void MilitaryChange(int newMilitaryValue)
    {
        militaryText.text = $"{newMilitaryValue.ToString()}";
        Debug.Log($"Military Value changed to: {newMilitaryValue}");
    }
    void InfluenceChange(int newInfluenceValue)
    {
        influenceText.text = $"{(int)(newInfluenceValue / (float)maxInfluence * 100)} %";
        Debug.Log($"Influence Value changed to: {newInfluenceValue}");
    }
    void SatisfactionChange(int newSatisfactionPercentage)
    {
        switch (newSatisfactionPercentage)
        {
            case (0):
                satisfactionImage.sprite = Resources.Load<Sprite>("Sprites/Icons/Satisfaction/0-Happy");
                break;
            case (1):
                satisfactionImage.sprite = Resources.Load<Sprite>("Sprites/Icons/Satisfaction/1-Smile");
                break;
            case (2):
                satisfactionImage.sprite = Resources.Load<Sprite>("Sprites/Icons/Satisfaction/2-Neutral");
                break;
            case (3):
                satisfactionImage.sprite = Resources.Load<Sprite>("Sprites/Icons/Satisfaction/3-Sad");
                break;
            case (4):
                satisfactionImage.sprite = Resources.Load<Sprite>("Sprites/Icons/Satisfaction/4-Angry");
                break;
            default:
                Debug.LogWarning("Satisfaction index is out of range (0-4).");
                break;
        }
        Debug.Log($"Satisfaction Percentage changed to: {newSatisfactionPercentage}");
    }
    void SafetyChange(int newSafetyPercentage)
    {
        switch (newSafetyPercentage)
        {
            case (0):
                safetyImage.sprite = Resources.Load<Sprite>($"{safetySpritePath}/0");
                break;
            case (1):
                safetyImage.sprite = Resources.Load<Sprite>($"{safetySpritePath}/1");
                break;
            case (2):
                safetyImage.sprite = Resources.Load<Sprite>($"{safetySpritePath}/2");
                break;
            case (3):
                safetyImage.sprite = Resources.Load<Sprite>($"{safetySpritePath}/3");
                break;
            default:
                Debug.LogWarning("Safety index is out of range (0-3).");
                break;
        }
        Debug.Log($"Safety Percentage changed to: {newSafetyPercentage}");
    }
    void TimeChange(int newTimeDay)
    {
        timeText.text = $"{((int)(newTimeDay/daysInYear)+1).ToString().PadLeft (3, '0')}";
    }
    void YearChange(int newTimeYear)
    {
        yearText.text = $"{((int)newTimeYear).ToString().PadLeft (4, 'X')}";
        Debug.Log($"Time Day changed to: {newTimeYear.ToString().PadLeft (4, 'X')}");
    }
    void LoseStatusChange(int newLoseStatus)
    {
        if (newLoseStatus != 0)
        {
            Debug.Log("Lose Status changed to: True. Game Over.");
            // Call lose function from Back End
        }
    }
}
