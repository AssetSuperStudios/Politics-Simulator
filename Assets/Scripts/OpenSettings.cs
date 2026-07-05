using UnityEngine;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    public void OpenMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 1;
        canvasSettings.interactable = true;
        canvasSettings.blocksRaycasts = true;
        CalendarTick.isPaused = true;
    }

    public void CloseMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 0;
        canvasSettings.interactable = false;
        canvasSettings.blocksRaycasts = false;
        CalendarTick.isPaused = false;
    }
}
