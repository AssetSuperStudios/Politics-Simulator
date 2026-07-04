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
    [SerializeField] CharacterStats playerData;
    // Private variables for Character Cycling
    private CharacterStats selectedCharacter;
    private int selectedIndex = 0;

    // Load initial character at Start
    void Start() {
        CharacterCycle(0);
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
        playerData.spriteImage = selectedCharacter.spriteImage;
        playerData.stringName = selectedCharacter.stringName;
        playerData.stringPath = selectedCharacter.stringPath;
        playerData.percentageMoneyModifier = selectedCharacter.percentageMoneyModifier;
        playerData.percentageMilitaryModifier = selectedCharacter.percentageMilitaryModifier;
        playerData.percentageInfluenceModifier = selectedCharacter.percentageInfluenceModifier;
    }
}
