using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Should work in game and not in the Unity Editor
    public void ExitButton() {
        Debug.Log("Exit");
        Application.Quit();
    }
}
