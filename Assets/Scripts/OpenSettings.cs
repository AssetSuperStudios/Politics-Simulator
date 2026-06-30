using UnityEngine;
using UnityEngine.UI;

public class OpenSettings : MonoBehaviour
{
    public void OpenMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 1;
        canvasSettings.interactable = true;
        canvasSettings.blocksRaycasts = true;
    }
}
