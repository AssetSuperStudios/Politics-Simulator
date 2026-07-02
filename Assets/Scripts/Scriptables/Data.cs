using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Data", menuName = "Scriptable Objects/Data")]
public class Data : ScriptableObject
{
    // Sample Data
    [SerializeField] private int _value;

    // Listener event that returns an int
    public event Action<int> OnValueChanged;

    // get
    // set
    public int Value {
        get => _value;
        set {
            // Change value only if the new value is different from the current value
            if (_value != value) {
                _value = value;
                // Invoke the event to notify subscribers of the change
                // ? is used to check if there are any subscribers before invoking the event
                // Such that if there are no subscribers, it won't throw a NullReferenceException
                OnValueChanged?.Invoke(_value);
            }
        }
    }

    // Method to change the value by a specified amount
    // Call through Data.ChangeValue(5)
    public void ChangeValue(int addAmount) {
        Value += addAmount;
    }
}
