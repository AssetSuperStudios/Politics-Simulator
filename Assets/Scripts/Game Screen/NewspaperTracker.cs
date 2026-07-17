// FRONT END

using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
// Game Screen : CanvasGameScreen/NewspaperHolder
// Attach this to the GameObject that holds the objects that track the game's newspaper pop up data

public class NewspaperTracker : MonoBehaviour
{
    // Serialize Data Scriptable Object
    [SerializeField] private UpdateData updatesObject;  // Assets/Scripts/Scriptables/Data/UpdateData.cs

    public void EventPopup(Boolean hasChoices, Action<Boolean> UpdatesPopup)
    {
        // Declare the button choices
        Transform buttonOne = transform.Find("ChoicesHolder/ButtonChoiceOne");
        Transform buttonTwo = transform.Find("ChoicesHolder/ButtonChoiceTwo");
        Transform buttonMain = transform.Find("ChoicesHolder/ButtonClose");

        // If the event has choices then show the choices
        // Otherwise, hide them
        if (hasChoices) {
            // Set the text value of the choices
            buttonOne.transform.Find("TextChoice").GetComponent<TMP_Text>().text = updatesObject.currentUpdate.updateOptionOne;
            buttonTwo.transform.Find("TextChoice").GetComponent<TMP_Text>().text = updatesObject.currentUpdate.updateOptionTwo;
            // Add button on click event listeners
            // Note: The functions change the value for the mascotDescription
            buttonOne.GetComponent<Button>().onClick.AddListener(() => {
                updatesObject.currentUpdate.updateFunctionOne.Invoke();
            });
            buttonTwo.GetComponent<Button>().onClick.AddListener(() => {
                updatesObject.currentUpdate.updateFunctionTwo.Invoke();
            });
            // Reveal the choices
            buttonOne.GetComponent<CanvasGroup>().alpha = 1;
            buttonOne.GetComponent<CanvasGroup>().interactable = true;
            buttonOne.GetComponent<CanvasGroup>().blocksRaycasts = true;
            buttonTwo.GetComponent<CanvasGroup>().alpha = 1;
            buttonTwo.GetComponent<CanvasGroup>().interactable = true;
            buttonTwo.GetComponent<CanvasGroup>().blocksRaycasts = true;
            // Disable the main button
            buttonMain.GetComponent<CanvasGroup>().interactable = false;
            buttonMain.GetComponent<CanvasGroup>().blocksRaycasts = false;
        } else {
            // Hide the choices
            buttonOne.GetComponent<CanvasGroup>().alpha = 0;
            buttonOne.GetComponent<CanvasGroup>().interactable = false;
            buttonOne.GetComponent<CanvasGroup>().blocksRaycasts = false;
            buttonTwo.GetComponent<CanvasGroup>().alpha = 0;
            buttonTwo.GetComponent<CanvasGroup>().interactable = false;
            buttonTwo.GetComponent<CanvasGroup>().blocksRaycasts = false;
            // Enable the main button
            buttonMain.GetComponent<CanvasGroup>().interactable = true;
            buttonMain.GetComponent<CanvasGroup>().blocksRaycasts = true;
        }
        
        // Set the newspaper values
        transform.Find("ImageIcon").GetComponent<Image>().sprite = Resources.Load<Sprite>(updatesObject.currentUpdate.updateSpritePath);
        transform.Find("TextBoundaryBox/TextUpdateSubtitle").GetComponent<TMP_Text>().text = $"Philippines | National <pos=60%>{updatesObject.currentUpdate.updateAuthorName}</pos>";
        transform.Find("TextBoundaryBox/TextUpdate").GetComponent<TMP_Text>().text = updatesObject.currentUpdate.updateFlavorText;
        
        // Open newspaper canvas
        CanvasGroup npCanvas = GetComponent<CanvasGroup>();
        npCanvas.alpha = 1;
        npCanvas.interactable = true;
        npCanvas.blocksRaycasts = true;
    }
}
