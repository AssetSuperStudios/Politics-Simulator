// FRONT END

using System.Collections;
using UnityEngine;
using UnityEngine.UI;
// Game Screen : CanvasGameScreen/CampaignHolder/ButtonsHolder/ButtonMove
// Attach this to the Button that triggers the animation

public class SlideAnimation : MonoBehaviour
{
    // Called by a button click
    // Animates the canvas parameter
    // Calls SlideRight()
    public void StartAnimation(RectTransform canvasTransform)
    {
        // Declare anchor values for the x dimension
        float anchorMaxStartX = canvasTransform.anchorMax.x;
        float anchorMinStartX = canvasTransform.anchorMin.x;

        // Starts the coroutine sliding animation
        StartCoroutine(SlideRight(canvasTransform, anchorMaxStartX, anchorMinStartX));
    }

    // Replaces the move button with the close button after the animation finishes
    void EndAnimation(RectTransform canvasTransform)
    {
        // Reveals the close button
        CanvasGroup buttonClose = canvasTransform.Find("ButtonsHolder/ButtonClose").GetComponent<CanvasGroup>();
        buttonClose.alpha = 1;
        buttonClose.interactable = true;
        buttonClose.blocksRaycasts = true;

        // Hides the move button by making it not interactable
        GetComponent<Button>().interactable = false;
    }

    // Animate the canvas sliding towards the right
    // Calls EndAnimation()
    IEnumerator SlideRight(RectTransform canvasTransform, float anchorMaxStart, float anchorMinStart)
    {
        // Animation variables
        // Time
        float duration = 0.5f;
        float elapsed = 0f;
        // Anchor values
        float anchorMaxGoal = 0.3f;
        float anchorMinGoal = 0.015f;
        
        // Store initial anchor values
        Vector2 currentAnchorMin = canvasTransform.anchorMin;
        Vector2 currentAnchorMax = canvasTransform.anchorMax;

        // Animate Texts and Images
        // While the elapsed time is still less than the intended duration time
        while (elapsed < duration)
        {
            // Forward the elapsed time
            elapsed += Time.deltaTime;
            // Convert the elapsed time into a percentage
            float normalizedTime = Mathf.Clamp01(elapsed / duration);

            // Animate Campaign Pop Up
            // Slowly slide the image bar until it reaches its max anchor
            // Interpolate
            currentAnchorMax.x = Mathf.Lerp(anchorMaxStart, anchorMaxGoal, normalizedTime);
            currentAnchorMin.x = Mathf.Lerp(anchorMinStart, anchorMinGoal, normalizedTime);
            // Set the calculated new values
            canvasTransform.anchorMax = currentAnchorMax;
            canvasTransform.anchorMin = currentAnchorMin;

            // Wait for the next frame
            yield return null;
        }

        // Set final values after finishing the animation
        currentAnchorMin.x = anchorMinGoal;
        currentAnchorMax.x = anchorMaxGoal;
        canvasTransform.anchorMin = currentAnchorMin;
        canvasTransform.anchorMax = currentAnchorMax;

        // Run ElectionEnd() after finalizing the animation
        EndAnimation(canvasTransform);
    }
}
