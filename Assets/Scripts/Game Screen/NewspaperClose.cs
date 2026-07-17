// FRONT END

using UnityEngine;
// Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonClose
// Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceOne
// Game Screen : CanvasGameScreen/NewspaperHolder/ChoicesHolder/ButtonChoiceTwo
// Attach this to a Button GameObject that closes the Newspaper Pop Up

public class NewspaperClose : MonoBehaviour
{
    // Serialize Canvas Group and UpdatesTracker script
    [SerializeField] private CanvasGroup canvasSettings;    // Game Screen : CanvasGameScreen/NewspaperHolder
    [SerializeField] private UpdatesTracker updatesScript;  // Game Screen : CanvasGameScreen/UpdatesHolder

    // Called by a button click
    // Hides the newspaper pop up and makes it uninteractable
    // It then calls the UpdatesPopup function to change the Updates Pop Up values
    public void CloseMenu()
    {
        Debug.Log("Called");
        canvasSettings.alpha = 0;
        canvasSettings.interactable = false;
        canvasSettings.blocksRaycasts = false;

        updatesScript.UpdatesPopup(false);
    }
}
