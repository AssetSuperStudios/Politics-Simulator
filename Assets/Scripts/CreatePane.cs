using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreatePane : MonoBehaviour
{
    // Serialize Actions List and Actions Pane Prefab
    [SerializeField] private GameObject actionsPanePrefab;
    [SerializeField] private Actions actionsReference;
    // Declare transform and integer which is assigned on button creation
    public Transform parentTransform;
    public int listIndex;

    public void CreateActionsPane()
    {
        // Instantiate the Actions Pane prefab
        GameObject actionsPane = Instantiate(actionsPanePrefab, parentTransform);
        // Assign the parent Game Object of script that makes the pane draggable
        actionsPane.GetComponent<DraggableUI>().parentObject = parentTransform.gameObject;
        // Set the values of the Actions Pane based on the action in the index selected
        var action = actionsReference.ActionList[listIndex];
        actionsPane.transform.Find("ButtonAction/TextBoundingBox/TextActionName").GetComponent<TMP_Text>().text = action.actionName;
        actionsPane.transform.Find("ResourcesHolder/MilitaryHolder/TextMoney").GetComponent<TMP_Text>().text = action.resourceMilitary.ToString();
        actionsPane.transform.Find("ResourcesHolder/InfluenceHolder/TextInfluence").GetComponent<TMP_Text>().text = action.resourceInfluence.ToString();
        actionsPane.transform.Find("ResourcesHolder/MoneyHolder/TextMoney").GetComponent<TMP_Text>().text = action.resourceMoney.ToString();
        actionsPane.transform.Find("ResourcesHolder/TimeHolder/TextTime").GetComponent<TMP_Text>().text = action.resourceTime.ToString();
        actionsPane.transform.Find("TextDescription").GetComponent<TMP_Text>().text = action.actionDescription;
        actionsPane.transform.Find("ButtonAction").GetComponent<Button>().onClick.AddListener(() => {
            bool success = action.actionFunctionCall.Invoke();
            if (success)
            {
                Debug.Log($"{action.actionName} executed successfully.");
                Destroy(actionsPane, 0.2f);
            }
            else
            {
                Debug.Log($"Not enough resources for to execute {action.actionName}.");
            }
        });
    }
}
