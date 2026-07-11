// FRONT END

using UnityEngine;
// Assets/Prefabs/AudioSourcePrefab.prefab [Universal]
// Attach this to any GameObject that needs to be persistent across scenes

public class PersistentObject : MonoBehaviour
{
    // Declare int and PersistentObject
    public int index;
    private static PersistentObject instance;

    // If there is no Game Object
    // Make this the old Game Object
    // Otherwise, a new one is found
    // And its index is different
    // Then destroy the old Game Object
    // Makes this new Game Object the old one
    // And prevent itself from being destroyed
    // And if the index is the same
    // Destroy the new Game Object instead
    void Awake() {
        if (instance != null && instance != this) {
            if (this.index == instance.index) {
                Destroy(gameObject);
                return;
            }

            Destroy(instance.gameObject);
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
