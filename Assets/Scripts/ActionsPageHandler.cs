using UnityEngine;
using UnityEngine.UI;
// Attach this to the GameObject holding the Actions button

public class ActionsPageHandler : MonoBehaviour
{
    // Serialize Actions List and Button Prefab
    [SerializeField] private Actions actionsReference;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject actionPanel;

    // Initialize the Actions Page on start
    void Start()
    {
        DisplayActions();
    }

    // Sets up OnValueChanged event listener for all Actions in the scene
    void OnEnable()
    {
        actionsReference.OnValueChanged += DisplayActions;
    }
    // Removes OnValueChanged event listener for all Actions in the scene
    void OnDisable()
    {
        actionsReference.OnValueChanged -= DisplayActions;
    }

    // Change the page contents of the Actions
    // Then create the buttons
    public void DisplayActions()
    {
        // Clear all existing action UI elements before displaying new ones
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Create a button for each action
        foreach (GameAction action in actionsReference.ActionList)
        {
            GameObject newButton = Instantiate(buttonPrefab, transform);
            // Get the Image component of the button and set its sprite
            newButton.transform.Find("ImageBoundingBox").GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>($"Sprites/Actions/{action.actionSpritePath}");
            // Assign the game object and index location parent of script that creates the Actions Pane
            newButton.GetComponent<CreatePane>().actionsPanel = actionPanel;
            newButton.GetComponent<CreatePane>().listIndex = actionsReference.ActionList.IndexOf(action);
            newButton.GetComponent<Button>().onClick.AddListener(() => {
                bool success = action.actionFunctionCall.Invoke();
                if (success)
                {Debug.Log($"{action.actionName} executed successfully.");}
                else
                {Debug.Log($"Not enough resources for to execute {action.actionName}.");}
            });
        }
    }
}
