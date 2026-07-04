using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DataTracker : MonoBehaviour
{
    // Serialize Data Scriptable Object
    [SerializeField] private Data playerData;
    // Serialize UI trackers
    [SerializeField] private TMP_Text classText;
    [SerializeField] private TMP_Text moneyText;
    [SerializeField] private TMP_Text militaryText;
    [SerializeField] private TMP_Text influenceText;
    [SerializeField] private Image satisfactionImage;
    [SerializeField] private Image safetyImage;
    [SerializeField] private TMP_Text timeText;
    // Serialize CharacterStats and Declare string path
    [SerializeField] private CharacterStats selectedCharacter;
    private string safetySpritePath;

    // Change data value on start
    void Start()
    {
        // Initialize string path for Safety sprites after loading CharacterStats
        safetySpritePath = $"Sprites/Icons/Safety/{selectedCharacter.stringPath}";

        ClassChange(playerData.ClassName);
        MoneyChange(playerData.MoneyValue);
        MilitaryChange(playerData.MilitaryValue);
        InfluenceChange(playerData.InfluenceValue);
        SatisfactionChange(playerData.SatisfactionPercentage);
        SafetyChange(playerData.SafetyPercentage);
        TimeChange(playerData.TimeDay);
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
        playerData.OnLoseStatusChanged -= LoseStatusChange;
    }

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
        influenceText.text = $"{newInfluenceValue.ToString()} %";
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
        timeText.text = $"{newTimeDay.ToString().PadLeft (3, '0')}";
        Debug.Log($"Time Day changed to: {newTimeDay.ToString().PadLeft (3, '0')}");
    }
    public void TimeIncrement()
    {
        playerData.TimeDay++;
    }
    void LoseStatusChange(bool newLoseStatus)
    {
        if (newLoseStatus)
        {
            Debug.Log("Lose Status changed to: True. Game Over.");
            // Call lose function from Back End
        }
    }
}
