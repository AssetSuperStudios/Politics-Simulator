// FRONT END

using UnityEngine;
using UnityEngine.UI;
using TMPro;
// Character Select : CanvasCharacterSelect
// Attach this to any GameObject

public class CharacterSelector : MonoBehaviour
{
    // Serialize Sprite and Text objects
    [SerializeField] Image selectedImage;               // Character Select : CanvasCharacterSelect/ImageBoundingBox/ImageCharacter
    [SerializeField] TMP_Text selectedName;             // Character Select : CanvasCharacterSelect/CharacterStatsHolder/TextName
    [SerializeField] TMP_Text selectedText;             // Character Select : CanvasCharacterSelect/CharacterStatsHolder/TextHolderBox/TextStats
    [SerializeField] TMP_Text selectedStats;            // Character Select : CanvasCharacterSelect/CharacterStatsHolder/TextHolderBox/TextVals
    // Serialize CharacterStats List
    [SerializeField] CharacterStats[] characterList;    // Assets/Scripts/Scriptables/Characters/   ActionStar, BhabymE, FatherD, Rocky, 
    // Serialize Data CharacterStats
    [SerializeField] CharacterStats characterStats;     // Assets/Scripts/Scriptables/Data/SelectedCharacter
    [SerializeField] private Data playerData;           // Assets/Scripts/Scriptables/Data/PlayerData
    [SerializeField] private Data lastPlayerData;       // Assets/Scripts/Scriptables/Data/LastPlayerData
    // Initialize variables for Character Cycling
    private CharacterStats selectedCharacter;
    private int selectedIndex = 0;

    // Load initial character at Start
    // Calls CharacterCycle() and NewPlayerData()
    void Start()
    {
        CharacterCycle(0);
        NewPlayerData();
    }

    // Sets the player data to the set initial values
    public void NewPlayerData()
    {
        playerData.ClassName = "Mayor";
        playerData.MoneyValue = 300;
        playerData.MilitaryValue = 50;
        playerData.InfluenceValue = 50;
        playerData.TimeDay = 1;
        playerData.LoseStatus = 0;
        playerData.LocationIndex = 0;
        playerData.SatisfactionPercentage = 0;
        playerData.SafetyPercentage = 0;
    }

    // Called on a button click
    // Saves initial player data into the save file backup
    public void BackupPlayerData()
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
    }

    // Called on a button click
    // Passes an integer, whether to move right (+1) or move left (-1)
    // Cycles through the length of the CharacterStats List
    // The 2nd operation is a fallback for a negative value case
    // Note: % is a remainder operation and not a modulo operation
    public void CharacterCycle(int intMove)
    {
        selectedIndex = (selectedIndex + intMove) % characterList.Length;
        selectedIndex = (selectedIndex + characterList.Length) % characterList.Length;
        selectedCharacter = characterList[selectedIndex];

        // Change the color of the value depending whether it is considered positive, negative or neutral
        var moneyNumber = TextColorChanger(selectedCharacter.percentageMoneyModifier);
        var militaryNumber = TextColorChanger(selectedCharacter.percentageMilitaryModifier);
        var influenceNumber = TextColorChanger(selectedCharacter.percentageInfluenceModifier);

        var moneyLabel = "Money Modifier:";
        var militaryLabel = "Military Modifier:";
        var influenceLabel = "Influence Modifier:";

        // Sets the text according to the character's data
        selectedImage.sprite = selectedCharacter.spriteImage;
        selectedName.SetText(selectedCharacter.stringName);
        selectedText.SetText($"{moneyLabel}\n" + 
                            $"{militaryLabel}\n" + 
                            $"{influenceLabel}");
        selectedStats.SetText($"{moneyNumber}\n" + 
                            $"{militaryNumber}\n" + 
                            $"{influenceNumber}");
        
        // Set the playerData to the selectedCharacter
        characterStats.spriteImage = selectedCharacter.spriteImage;
        characterStats.stringName = selectedCharacter.stringName;
        characterStats.stringPath = selectedCharacter.stringPath;
        characterStats.percentageMoneyModifier = selectedCharacter.percentageMoneyModifier;
        characterStats.percentageMilitaryModifier = selectedCharacter.percentageMilitaryModifier;
        characterStats.percentageInfluenceModifier = selectedCharacter.percentageInfluenceModifier;
    }

    // Adds a color text changer code to the text parameter
    // If the value is less than 1, then it's negative (red)
    // If the value is greater than 1, then it's positive (green)
    // And neutral color for a value equal to 1, neutral (normal color)
    string TextColorChanger(float modifierValue)
    {
        var textColor = "";

        switch (modifierValue)
        {
            case (1f):
                textColor = $"{modifierValue}x";
                break;
            case (> 1f):
                textColor = $"<color=#00a86b>{modifierValue}</color>x";
                break;
            case (< 1f):
                textColor = $"<color=red>{modifierValue}</color>x";
                break;
        }

        return textColor;
    }
}
