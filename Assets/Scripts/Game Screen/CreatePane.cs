// FRONT END

using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
// Assets/Prefabs/ButtonActionPrefab.prefab [Game Screen]
// Attach this to the GameObject that when hovered upon, sets the Action Panel contents

public class CreatePane : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Serialize Actions List
    [SerializeField] private Actions actionsReference;
    // Declare Game Object and integer which is assigned on button creation
    public GameObject actionsPanel;
    public int listIndex;

    // Ran when the cursor hovers on this object
    // Sets the contents of the Actions Panel
    // Then reveals and makes the panel interactable
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Look for each component in the hierarchy
        // Then set the values of the Actions Pane based on the action in the index selected
        var action = actionsReference.ActionList[listIndex];
        actionsPanel.transform.Find("TitleBoundaryBox/TextBoundingBox/TextActionName").GetComponent<TMP_Text>().text = action.actionName;
        actionsPanel.transform.Find("ResourcesHolder/MilitaryHolder/TextMilitary").GetComponent<TMP_Text>().text = action.resourceMilitary.ToString();
        actionsPanel.transform.Find("ResourcesHolder/InfluenceHolder/TextInfluence").GetComponent<TMP_Text>().text = action.resourceInfluence.ToString();
        actionsPanel.transform.Find("ResourcesHolder/MoneyHolder/TextMoney").GetComponent<TMP_Text>().text = action.resourceMoney.ToString();
        actionsPanel.transform.Find("ResourcesHolder/TimeHolder/TextTime").GetComponent<TMP_Text>().text = action.resourceTime.ToString();
        actionsPanel.transform.Find("TextDescription").GetComponent<TMP_Text>().text = action.actionDescription;
        
        // Reveals and makes the panel interactable
        actionsPanel.GetComponent<CanvasGroup>().alpha = 1;
        actionsPanel.GetComponent<CanvasGroup>().interactable = true;
        actionsPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    // Ran when the cursor stops hovering on this object
    // Hides the panel and makes the panel not interactable
    public void OnPointerExit(PointerEventData eventData)
    {
        actionsPanel.GetComponent<CanvasGroup>().alpha = 0;
        actionsPanel.GetComponent<CanvasGroup>().interactable = false;
        actionsPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
