using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterSelector : MonoBehaviour
{
    // Serialize Sprite and Text
    [SerializeField] Image selectedImage;
    [SerializeField] TMP_Text selectedName;
    [SerializeField] TMP_Text selectedText;
    // Serialize CharacterStats List
    [SerializeField] CharacterStats[] characterList;
    // Serialize Data CharacterStats
    [SerializeField] CharacterStats characterStats;
    [SerializeField] private Data playerData;
    [SerializeField] private Data lastPlayerData;
    // Private variables for Character Cycling
    private CharacterStats selectedCharacter;
    private int selectedIndex = 0;

    // Load initial character at Start
    void Start() {
        CharacterCycle(0);

        NewPlayerData();
    }

    void NewPlayerData() {
        playerData.ClassName = "Mayor";
        playerData.MoneyValue = 300;
        playerData.MilitaryValue = 50;
        playerData.InfluenceValue = 50;
        playerData.TimeDay = 1;
        playerData.LoseStatus = 0;
        playerData.LocationIndex = 0;
        playerData.SatisfactionPercentage = 0;
        playerData.SafetyPercentage = 0;

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
    public void CharacterCycle(int intMove) {
        selectedIndex = (selectedIndex + intMove) % characterList.Length;
        selectedIndex = (selectedIndex + characterList.Length) % characterList.Length;
        selectedCharacter = characterList[selectedIndex];

        selectedImage.sprite = selectedCharacter.spriteImage;
        selectedName.SetText(selectedCharacter.stringName);
        selectedText.SetText($"Money Modifier: {selectedCharacter.percentageMoneyModifier}x \n" + 
                            $"Military Modifier: {selectedCharacter.percentageMilitaryModifier}x \n" + 
                            $"Influence Modifier: {selectedCharacter.percentageInfluenceModifier}x");
        
        // Set the playerData to the selectedCharacter
        characterStats.spriteImage = selectedCharacter.spriteImage;
        characterStats.stringName = selectedCharacter.stringName;
        characterStats.stringPath = selectedCharacter.stringPath;
        characterStats.percentageMoneyModifier = selectedCharacter.percentageMoneyModifier;
        characterStats.percentageMilitaryModifier = selectedCharacter.percentageMilitaryModifier;
        characterStats.percentageInfluenceModifier = selectedCharacter.percentageInfluenceModifier;
    }
}
