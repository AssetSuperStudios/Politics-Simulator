// FRONT END

using UnityEngine;
// Assets/Prefabs/SettingsPrefab.prefab/MainSettingsHolder/ButtonExit [Universal]
// Main Menu : CanvasMenu/ButtonSettings                        [OpenMenu : CanvasSettings]
// Character Select : CanvasCharacterSelect/ButtonSettings      [OpenMenu : CanvasSettings]
// Game Screen : CanvasGameScreen/ButtonSettings                [OpenMenu : CanvasSettings]
// Lose Scene : CanvasLose/ButtonSettings                       [OpenMenu : CanvasSettings]
// Win Scene : CanvasWin/ButtonSettings                         [OpenMenu : CanvasSettings]
// Attach this to a Button GameObject that opens or closes a Menu

public class OpenSettings : MonoBehaviour
{
    // Called by a button click
    // Reveals the parameter canvas and makes it interactable
    public void OpenMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 1;
        canvasSettings.interactable = true;
        canvasSettings.blocksRaycasts = true;
        CalendarTick.isPaused = true;
    }

    // Called by a button click
    // Hides the parameter canvas and makes it uninteractable
    public void CloseMenu(CanvasGroup canvasSettings)
    {
        canvasSettings.alpha = 0;
        canvasSettings.interactable = false;
        canvasSettings.blocksRaycasts = false;
        CalendarTick.isPaused = false;
    }
}
