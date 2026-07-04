using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using TMPro;
// Attach this to the GameObject holding the Actions button

public class ActionsPageHandler : MonoBehaviour
{
    // Serialize Actions List and Button Prefab
    [SerializeField] private Actions actionsReference;
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private GameObject objectParent;
    // Serialize Text for page changing
    [SerializeField] private TMP_Text textPage;
    // Initialize page variables
    private int pageMax = 1;
    private int pageSize = 12;
    private int pageCurrent = 1;

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
    public void NextPage(int pageAdd)
    {
        // Loop through the pages based on a 0-based index
        pageCurrent -= 1;
        pageCurrent = (pageCurrent + pageAdd) % pageMax;
        pageCurrent = (pageCurrent + pageMax) % pageMax; // CASE: negative value
        pageCurrent += 1;
        // Create a temporary list from the slice of a list based on page size
        List<GameAction> tempList = actionsReference.ActionList.Skip((pageCurrent - 1) * pageSize).Take(pageSize).ToList();

        // Clear all existing action UI elements before displaying new ones
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        // Create a button for each action
        foreach (GameAction action in tempList)
        {
            GameObject newButton = Instantiate(buttonPrefab, transform);
            // Get the Image component of the button and set its sprite
            newButton.transform.Find("ImageBoundingBox").GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>($"Sprites/Actions/{action.actionSpritePath}");
            // Assign the transform and index location parent of script that creates the Actions Pane
            newButton.GetComponent<CreatePane>().parentTransform = objectParent.transform;
            newButton.GetComponent<CreatePane>().listIndex = actionsReference.ActionList.IndexOf(action);
        }

        // Update the page text
        textPage.text = $"Page {pageCurrent} of {pageMax}";
    }

    // Initialize the maximum number of pages
    // Then create the page
    public void DisplayActions()
    {
        pageMax = Mathf.Max(1, (int)Mathf.Ceil((float)actionsReference.ActionList.Count / pageSize));
        NextPage(0);
    }
}
