// FRONT END

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
// Game Screen : CanvasGameScreen/ActionsHolder/ButtonsHolder
// Attach this to the GameObject holding the Actions button

public class ActionsPageHandler : MonoBehaviour
{
    // Serialize Actions List and Button Prefab
    [SerializeField] private Actions actionsReference;  // Assets/Scripts/Scriptables/Data/ActionsList.cs
    [SerializeField] private GameObject buttonPrefab;   // Assets/Prefabs/ButtonActionPrefab.prefab
    [SerializeField] private GameObject actionPanel;    // Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ActionPanel

    // Initialize the Actions Page on start
    // Calls DisplayActions()
    void Start()
    {DisplayActions();}

    // Sets up OnValueChanged event listener for all Actions in the scene
    // Calls DisplayActions()
    void OnEnable()
    {actionsReference.OnValueChanged += DisplayActions;}
    // Removes OnValueChanged event listener for all Actions in the scene
    // Calls DisplayActions()
    void OnDisable()
    {actionsReference.OnValueChanged -= DisplayActions;}

    // Reset the page contents of the Actions
    // Then create the buttons
    // Uses Assets/Scripts/CreatePane.cs
    public void DisplayActions()
    {
        // Clear all existing action UI elements before displaying new ones
        foreach (Transform child in transform)
        {Destroy(child.gameObject);}

        // Creates a button for each action in the list
        foreach (GameAction action in actionsReference.ActionList)
        {
            // Create the button
            GameObject newButton = Instantiate(buttonPrefab, transform);
            // Get the Image component of the button and set its sprite
            newButton.transform.Find("ImageBoundingBox").GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>($"Sprites/Actions/{action.actionSpritePath}");
            // Assign the game object and index location parent of the script that creates the Actions Panel
            newButton.GetComponent<CreatePane>().actionsPanel = actionPanel;
            newButton.GetComponent<CreatePane>().listIndex = actionsReference.ActionList.IndexOf(action);
            // Adds an onClick event for the button
            // Calls the action function and plays one of its audio
            newButton.GetComponent<Button>().onClick.AddListener(() => {
                bool success = action.actionFunctionCall.Invoke();
                if (success)
                {
                    Debug.Log($"{action.actionName} executed successfully.");
                    newButton.GetComponents<AudioSource>()[0].Play();
                }
                else
                {
                    Debug.Log($"Not enough resources for to execute {action.actionName}.");
                    newButton.GetComponents<AudioSource>()[1].Play();
                }
            });
        }
    }
}
