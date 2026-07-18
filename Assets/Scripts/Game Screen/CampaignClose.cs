// FRONT END
using UnityEngine;
using UnityEngine.UI;
// Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonClose
// Attach this to a Button GameObject that closes the Campaign Pop Up

public class CampaignClose : MonoBehaviour
{
    // Serialize Canvas Group and UpdatesTracker script
    [SerializeField] private CanvasGroup campaignCanvas;    // Game Screen : CanvasGameScreen/

    // Called by a button click
    // Hides the campaign pop up and makes it uninteractable
    // It also resets it to its original state
    public void CloseMenu()
    {
        campaignCanvas.alpha = 0;
        campaignCanvas.interactable = false;
        campaignCanvas.blocksRaycasts = false;

        // Declare anchor values
        float anchorMin = -0.265f;
        float anchorMax = 0.02f;
        // Store initial anchor values
        RectTransform campaignTransform = campaignCanvas.GetComponent<RectTransform>();
        Vector2 currentAnchorMax = campaignTransform.anchorMax;
        Vector2 currentAnchorMin = campaignTransform.anchorMin;
        // Reset the final anchor values
        currentAnchorMax.x = anchorMax;
        currentAnchorMin.x = anchorMin;
        campaignTransform.anchorMax = currentAnchorMax;
        campaignTransform.anchorMin = currentAnchorMin;

        // Hide the close button
        CanvasGroup buttonClose = GetComponent<CanvasGroup>();
        buttonClose.alpha = 0;
        buttonClose.interactable = false;
        buttonClose.blocksRaycasts = false;

        // Reveals the move button by making it interactable again
        campaignCanvas.transform.Find("ButtonsHolder/ButtonMove").GetComponent<Button>().interactable = true;
    }
}
