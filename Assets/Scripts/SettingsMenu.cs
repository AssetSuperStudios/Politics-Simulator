using UnityEngine;
using UnityEngine.UI;
public class SettingsMenu : MonoBehaviour
{
    public void CloseMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 0;
        canvasSettings.interactable = false;
        canvasSettings.blocksRaycasts = false;
    }

    public void OpenTab(CanvasGroup canvasTab)
    {
        canvasTab.alpha = 1;
        canvasTab.interactable = true;
        canvasTab.blocksRaycasts = true;
    }

    public void CloseTab(CanvasGroup canvasTab)
    {
        canvasTab.alpha = 0;
        canvasTab.interactable = false;
        canvasTab.blocksRaycasts = false;
    }
}
