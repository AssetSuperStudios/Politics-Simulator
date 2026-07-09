using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class CreatePane : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Serialize Actions List and Actions Pane Prefab
    [SerializeField] private Actions actionsReference;
    // Declare game object and integer which is assigned on button creation
    public GameObject actionsPanel;
    public int listIndex;

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Set the values of the Actions Pane based on the action in the index selected
        var action = actionsReference.ActionList[listIndex];
        actionsPanel.transform.Find("ButtonAction/TextBoundingBox/TextActionName").GetComponent<TMP_Text>().text = action.actionName;
        actionsPanel.transform.Find("ResourcesHolder/MilitaryHolder/TextMoney").GetComponent<TMP_Text>().text = action.resourceMilitary.ToString();
        actionsPanel.transform.Find("ResourcesHolder/InfluenceHolder/TextInfluence").GetComponent<TMP_Text>().text = action.resourceInfluence.ToString();
        actionsPanel.transform.Find("ResourcesHolder/MoneyHolder/TextMoney").GetComponent<TMP_Text>().text = action.resourceMoney.ToString();
        actionsPanel.transform.Find("ResourcesHolder/TimeHolder/TextTime").GetComponent<TMP_Text>().text = action.resourceTime.ToString();
        actionsPanel.transform.Find("TextDescription").GetComponent<TMP_Text>().text = action.actionDescription;
        // actionsPane.transform.Find("ButtonAction").GetComponent<Button>().onClick.AddListener(() => {
        //     bool success = action.actionFunctionCall.Invoke();
        //     if (success)
        //     {
        //         Debug.Log($"{action.actionName} executed successfully.");
        //         Destroy(actionsPane, 0.2f);
        //     }
        //     else
        //     {
        //         Debug.Log($"Not enough resources for to execute {action.actionName}.");
        //     }
        // });
        actionsPanel.GetComponent<CanvasGroup>().alpha = 1;
        actionsPanel.GetComponent<CanvasGroup>().interactable = true;
        actionsPanel.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        actionsPanel.GetComponent<CanvasGroup>().alpha = 0;
        actionsPanel.GetComponent<CanvasGroup>().interactable = false;
        actionsPanel.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
}
