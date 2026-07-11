// FRONT END

using UnityEngine;
using UnityEngine.UI;
// Assets/Prefabs/SettingsPrefab.prefab/MainSettingsHolder/ButtonExit [Universal]
// Main Menu : CanvasMenu/ButtonSettings
// Character Select : CanvasCharacterSelect/ButtonSettings
// Game Screen : CanvasGameScreen/ButtonSettings
// Lose Scene : CanvasLose/ButtonSettings
// Win Scene : CanvasWin/ButtonSettings
// Attach this to a Button GameObject that opens the Settings Menu

public class OpenSettings : MonoBehaviour
{
    // Called by a button click
    // Reveals the settings canvas and makes it interactable
    public void OpenMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 1;
        canvasSettings.interactable = true;
        canvasSettings.blocksRaycasts = true;
        CalendarTick.isPaused = true;
    }

    // Called by a button click
    // Hides the settings canvas and makes it uninteractable
    public void CloseMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 0;
        canvasSettings.interactable = false;
        canvasSettings.blocksRaycasts = false;
        CalendarTick.isPaused = false;
    }
}
