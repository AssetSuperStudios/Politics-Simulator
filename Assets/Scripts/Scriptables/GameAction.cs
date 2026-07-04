using UnityEngine;
using System;

// "Serialization is the automatic process of transforming data structures or GameObject states
// into a format that Unity can store and reconstruct later."
// https://docs.unity3d.com/Manual/script-serialization.html
[Serializable]
// Sample GameAction class to hold action data
public class GameAction
{
    public string actionName;
    public string actionSpritePath;
    public int resourceMilitary;
    public int resourceInfluence;
    public int resourceMoney;
    public int resourceTime;
    public string actionDescription;
    public Func<bool> actionFunctionCall;
}
