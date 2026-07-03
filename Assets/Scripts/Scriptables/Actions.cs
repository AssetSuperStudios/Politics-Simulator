using UnityEngine;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Actions", menuName = "Scriptable Objects/Actions")]
public class Actions : ScriptableObject
{
    // Sample Data
    // Serialize with default empty list
    [SerializeField] private List<GameAction> _actionList = new List<GameAction>();

    // Listener event that returns an int
    public event Action OnValueChanged;

    // get
    // set
    public List<GameAction> ActionList {
        get => _actionList;
        set {
            // Change value only if the new value is different from the current value
            if (_actionList != value) {
                _actionList = value;
                // Invoke the event to notify subscribers of the change
                // ? is used to check if there are any subscribers before invoking the event
                // Such that if there are no subscribers, it won't throw a NullReferenceException
                OnValueChanged?.Invoke();
            }
        }
    }

    // Inspector Testing Only
    // Keep a cache of the values to compare against in the editor
    private int _oldActionList;
    private void OnValidate()
    {
        // Only fire if the new Inspector value doesn't match the old cached value
        if (_actionList.Count != _oldActionList)
        {
            _oldActionList = _actionList.Count;
            OnValueChanged?.Invoke();
        }
    }
}

// See GameActionsManager.cs
// To set and create a new ActionList:
//      Add a reference to this Actions ScriptableObject
// public Actions actionsReference;
//      Create a temp list
// List<GameAction> tempList = new List<GameAction>();
//      Create a new GameAction object
// GameAction newActionName = new GameAction {
//   actionName = "Action Name",
//   actionResources = "Resources OR List<Resources>",
//   actionDescription = "Description ...",
//   actionFunctionCall = FunctionName
// };
//      Add new GameAction objects to the temp list
// tempList.Add(newActionName);
//      etc... use the set operation
// actionsReference.ActionList = tempList;