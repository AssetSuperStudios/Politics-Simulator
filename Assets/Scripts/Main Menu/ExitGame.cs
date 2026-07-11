// FRONT END

using UnityEngine;
// Main Menu : CanvasMenu/ButtonResign
// Attach this to the Button GameObject that handles exiting the game

public class ExitGame : MonoBehaviour
{
    // Called on button click
    // Closes the game
    public void ExitButton() {
        Debug.Log("Exit");
        Application.Quit();
    }
}
