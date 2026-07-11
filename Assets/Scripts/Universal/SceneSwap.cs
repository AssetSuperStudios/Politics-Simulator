// FRONT END

using UnityEngine;
using UnityEngine.SceneManagement;
// Assets/Prefabs/SettingsPrefab.prefab/MainSettingsHolder/ButtonsMenu [Universal]
// Main Menu : CanvasMenu/ButtonRun
// Character Select : CanvasCharacterSelect/ButtonResign
// Character Select : CanvasCharacterSelect/ButtonRun
// Game Screen : CanvasGameScreen
// Lose Scene : CanvasLose/ButtonExit
// Lose Scene : CanvasLose/ButtonReturn
// Win Scene : CanvasWin/ButtonTxtPrefab
// Attach to the Button GameObject that handles the scene swap mechanism or to any GameObject that can be called by scripts

public class SceneSwap : MonoBehaviour
{
    // Called by button click or certain scripts (GameCondition.cs)
    // Swaps the scene based on the parameter name
    // [TASK]
    // Add all scripts that access this
    public void SceneSwapper(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
