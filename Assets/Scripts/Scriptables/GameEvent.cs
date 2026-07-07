using UnityEngine;

[System.Serializable]
public class GameEvent
{
    public string eventTitle;
    
    [TextArea(3, 5)] 
    public string eventDescription;
    
    [Header("Base Stat Modifiers (Before Class Multipliers)")]
    public long moneyChange;
    public float militaryChange;
    public float influenceChange;
}