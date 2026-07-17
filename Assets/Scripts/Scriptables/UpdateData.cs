using System;
using UnityEngine;

[System.Serializable]
public struct Updates
{
    [Header("Update Data")]
    /// <summary>
    /// Detailed description of the update.
    /// </summary>
    public string updateDescription;
    /// <summary>
    /// Location of the sprite in Sprites/Icons/Updates/.
    /// </summary>
    public string updateSpritePath;
    /// <summary>
    /// Flavor text accompanying the update.
    /// </summary>
    public string updateFlavorText;
    /// <summary>
    /// Tells whether the update is an event or not.
    /// </summary>

    // TEMP TESTING //
    public UpdateType updateType;
    public string updateOptionOne;
    public string updateOptionTwo;
    public Action updateFunctionOne;
    public Action updateFunctionTwo;
    public string updateAuthorName;
    // TEMP TESTING //
}

// TEMP TESTING //
public enum UpdateType
{
    action,
    eventBase,
    eventChoice
}
// TEMP TESTING //

[CreateAssetMenu(fileName = "UpdateData", menuName = "Scriptable Objects/UpdateData")]
public class UpdateData : ScriptableObject
{
    public static event Action OnUpdate;

    [SerializeField] private Updates _currentUpdate;
    public Updates currentUpdate => _currentUpdate;
    
    /// <summary>
    /// Call from any script to change the update description, flavor text, and sprite location.       
    /// </summary>
    /// <param name="update"></param>
    public void newUpdateData(Updates update)
    {
        _currentUpdate = update;
        OnUpdate?.Invoke();
    }

    // Inspector testing
    private Updates _oldUpdate;
    private void OnValidate()
    {
        if (!object.Equals(_currentUpdate, _oldUpdate))
        {
            _oldUpdate = _currentUpdate;
            OnUpdate?.Invoke();
        }
    }
}
