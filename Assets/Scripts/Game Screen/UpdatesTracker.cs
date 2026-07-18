// FRONT END

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using System;
using TMPro;
// Game Screen : CanvasGameScreen/UpdatesHolder
// Attach this to the GameObject that holds the objects that track the game's update data

public class UpdatesTracker : MonoBehaviour
{
    // Serialize Data Scriptable Object
    [SerializeField] private UpdateData updatesObject;  // Assets/Scripts/Scriptables/Data/UpdateData.cs
    // Serialize script component that handles the Newspaper Functions
    [SerializeField] private NewspaperTracker newspaperScript; // Game Screen : CanvasGameScreen/NewspaperHolder
    // Serialize UI trackers
    [SerializeField] private TMP_Text notifText;        // Game Screen : CanvasGameScreen/UpdatesHolder/NotifBoundaryBox/TextBoundaryBox/TextNotifOne
    [SerializeField] private TMP_Text updatesAuthor;      // Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/TextBoundaryBox/TextUpdateSubtitle
    [SerializeField] private TMP_Text updatesText;      // Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/TextBoundaryBox/TextUpdate
    [SerializeField] private Image updatesImage;        // Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/ImageIcon
    // Declare audio component
    private AudioSource playAudio;
    // Initialize sprite path
    private string spriteLocation = "Sprites/Icons/Updates";

    // Initialize the values at the start
    // Calls NewUpdates()
    void Start()
    {
        playAudio = GetComponent<AudioSource>();
        NewUpdates();
    }

    // Sets up OnUpdate event listener for Update Data in the scene
    // Calls NewUpdates()
    void OnEnable()
    {UpdateData.OnUpdate += NewUpdates;}
    // Removes OnUpdate event listener for Update Data in the scene
    // Calls NewUpdates()
    void OnDisable()
    {UpdateData.OnUpdate -= NewUpdates;}

    // Manage the functions called based on the type of update, the event listener receives
    // Generally changes the contents of the Updates and Events Pop Up based on the new values that Update Data receives
    void NewUpdates()
    {
        // Check what type of update it is
        switch (updatesObject.currentUpdate.updateType) {
            // Is it a base event
            case UpdateType.eventBase:
                playAudio.Play();
                newspaperScript.EventPopup(false, UpdatesPopup);
                break;
            // Is it a choice event
            case UpdateType.eventChoice:
                playAudio.Play();
                newspaperScript.EventPopup(true, UpdatesPopup);
                break;
            // Is it an action
            case UpdateType.action:
                UpdatesPopup(true);
                break;
            // Wrong update type
            default:
                Debug.LogWarning($"update type '{updatesObject.currentUpdate.updateType}' unknown");
                break;
        }
    }

    public void UpdatesPopup(Boolean isAction)
    {
        notifText.text = updatesObject.currentUpdate.updateDescription;
        if (!isAction)
        {
            updatesImage.sprite = Resources.Load<Sprite>($"{spriteLocation}/{updatesObject.currentUpdate.updateSpritePath}");
            updatesAuthor.text = $"Philippines | National <pos=50%>{updatesObject.currentUpdate.updateAuthorName}</pos>";
            updatesText.text = updatesObject.currentUpdate.updateFlavorText;
        }
    }
}
