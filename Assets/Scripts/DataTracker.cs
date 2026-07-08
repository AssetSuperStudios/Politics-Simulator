using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

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
    [SerializeField] private TMP_Text yearText;
    [SerializeField] private GameObject buttonHolder;
    // Serialize CharacterStats and Declare string path
    [SerializeField] private CharacterStats selectedCharacter;
    private string safetySpritePath;
    [SerializeField] public static int maxInfluence = 680;
    [SerializeField] public static int daysInYear = 360;

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

    void ClassChange(string newClassName)
    {
        classText.text = newClassName;
        var tempList = buttonHolder.GetComponentsInChildren<Button>();
        var tempCount = 0;
        switch (newClassName)
        {
            case ("Mayor"):
                foreach (var buttonItem in tempList)
                {
                    if (tempCount < 3)
                    {
                        buttonItem.interactable = true;
                    } else
                    {
                        buttonItem.interactable = false;
                    }

                    tempCount++;
                }
                break;
            case ("Governor"):
                foreach (var buttonItem in tempList)
                {
                    if (tempCount < 4)
                    {
                        buttonItem.interactable = true;
                    } else
                    {
                        buttonItem.interactable = false;
                    }

                    tempCount++;
                }
                break;
            case ("Congress"):
                foreach (var buttonItem in tempList)
                {
                    if (tempCount < 5)
                    {
                        buttonItem.interactable = true;
                    } else
                    {
                        buttonItem.interactable = false;
                    }

                    tempCount++;
                }
                break;
            case ("Senator"):
                foreach (var buttonItem in tempList)
                {
                    if (tempCount < 6)
                    {
                        buttonItem.interactable = true;
                    } else
                    {
                        buttonItem.interactable = false;
                    }

                    tempCount++;
                }
                break;
            case ("VP"):
                foreach (var buttonItem in tempList)
                {
                    if (tempCount < 7)
                    {
                        buttonItem.interactable = true;
                    } else
                    {
                        buttonItem.interactable = false;
                    }

                    tempCount++;
                }
                break;
            case ("President"):
                foreach (var buttonItem in tempList)
                {
                    if (tempCount < 8)
                    {
                        buttonItem.interactable = true;
                    } else
                    {
                        buttonItem.interactable = false;
                    }

                    tempCount++;
                }
                break;
            default:
                Debug.LogError("That class does not exist.");
                break;
        }

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
