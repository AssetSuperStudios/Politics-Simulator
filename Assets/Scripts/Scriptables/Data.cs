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

    // Additional Temp Data
    [SerializeField] private string _className;
    public event Action<string> OnClassNameChanged;
    public string ClassName {
        get => _className;
        set {
            if (_className != value) {
                _className = value;
                OnClassNameChanged?.Invoke(_className);
            }
        }
    }

    [SerializeField] private int _moneyValue;
    public event Action<int> OnMoneyValueChanged;
    public int MoneyValue {
        get => _moneyValue;
        set {
            if (_moneyValue != value) {
                _moneyValue = value;
                OnMoneyValueChanged?.Invoke(_moneyValue);
            }
        }
    }

    [SerializeField] private int _militaryValue;
    public event Action<int> OnMilitaryValueChanged;
    public int MilitaryValue {  
        get => _militaryValue;
        set {
            if (_militaryValue != value) {
                _militaryValue = value;
                OnMilitaryValueChanged?.Invoke(_militaryValue);
            }
        }
    }

    [SerializeField] private int _influenceValue;
    public event Action<int> OnInfluenceValueChanged;
    public int InfluenceValue {
        get => _influenceValue;
        set {
            if (_influenceValue != value) {
                _influenceValue = value;
                OnInfluenceValueChanged?.Invoke(_influenceValue);
            }
        }
    }

    [SerializeField] private int _satisfactionPercentage;
    public event Action<int> OnSatisfactionPercentageChanged;
    public int SatisfactionPercentage {
        get => _satisfactionPercentage;
        set {
            if (_satisfactionPercentage != value) {
                _satisfactionPercentage = value;
                OnSatisfactionPercentageChanged?.Invoke(_satisfactionPercentage);
            }
        }
    }

    [SerializeField] private int _safetyPercentage;
    public event Action<int> OnSafetyPercentageChanged;
    public int SafetyPercentage {
        get => _safetyPercentage;
        set {
            if (_safetyPercentage != value) {
                _safetyPercentage = value;
                OnSafetyPercentageChanged?.Invoke(_safetyPercentage);
            }
        }
    }

    [SerializeField] private int _timeDay;
    public event Action<int> OnTimeDayChanged;
    public int TimeDay {
        get => _timeDay;
        set {
            if (_timeDay != value) {
                _timeDay = value;
                OnTimeDayChanged?.Invoke(_timeDay);
            }
        }
    }

    [SerializeField] private bool _loseStatus;
    public event Action<bool> OnLoseStatusChanged;
    public bool LoseStatus {
        get => _loseStatus;
        set {
            if (_loseStatus != value) {
                _loseStatus = value;
                OnLoseStatusChanged?.Invoke(_loseStatus);
            }
        }
    }

    // Index of 0 to 7
    [SerializeField] private int _locationIndex;
    public event Action<int> OnLocationChanged;
    public int LocationIndex {
        get => _locationIndex;
        set {
            if (_locationIndex != value) {
                _locationIndex = value;
                OnLocationChanged?.Invoke(_locationIndex);
            }
        }
    }

    // Inspector Testing Only
    // Keep a cache of the values to compare against in the editor
    private string _oldClassName;
    private int _oldMoneyValue;
    private int _oldMilitaryValue;
    private int _oldInfluenceValue;
    private int _oldSatisfaction;
    private int _oldSafety;
    private int _oldTimeDay;
    private bool _oldLoseStatus;
    private int _oldLocationIndex;
    private void OnValidate()
    {
        // Only fire if the new Inspector value doesn't match the old cached value
        if (_className != _oldClassName)
        {
            _oldClassName = _className;
            OnClassNameChanged?.Invoke(_className);
        }

        if (_moneyValue != _oldMoneyValue)
        {
            _oldMoneyValue = _moneyValue;
            OnMoneyValueChanged?.Invoke(_moneyValue);
        }

        if (_militaryValue != _oldMilitaryValue)
        {
            _oldMilitaryValue = _militaryValue;
            OnMilitaryValueChanged?.Invoke(_militaryValue);
        }

        if (_influenceValue != _oldInfluenceValue)
        {
            _oldInfluenceValue = _influenceValue;
            OnInfluenceValueChanged?.Invoke(_influenceValue);
        }

        if (_satisfactionPercentage != _oldSatisfaction)
        {
            _oldSatisfaction = _satisfactionPercentage;
            OnSatisfactionPercentageChanged?.Invoke(_satisfactionPercentage);
        }

        if (_safetyPercentage != _oldSafety)
        {
            _oldSafety = _safetyPercentage;
            OnSafetyPercentageChanged?.Invoke(_safetyPercentage);
        }

        if (_timeDay != _oldTimeDay)
        {
            _oldTimeDay = _timeDay;
            OnTimeDayChanged?.Invoke(_timeDay);
        }

        if (_loseStatus != _oldLoseStatus)
        {
            _oldLoseStatus = _loseStatus;
            OnLoseStatusChanged?.Invoke(_loseStatus);
        }

        if (_locationIndex != _oldLocationIndex)
        {
            _oldLocationIndex = _locationIndex;
            OnLocationChanged?.Invoke(_locationIndex);
        }
    }
}
