using UnityEngine;

public class ClosePane : MonoBehaviour
{
    // Closes the Actions Pane
    public void CloseActionsPane(GameObject actionsPane)
    {
        Destroy(actionsPane, 0.2f);
    }
}
