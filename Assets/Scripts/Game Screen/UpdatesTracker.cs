// FRONT END

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Threading.Tasks;
// Game Screen : CanvasGameScreen/UpdatesHolder
// Attach this to the GameObject that holds the objects that track the game's update data

public class UpdatesTracker : MonoBehaviour
{
    // Serialize Data Scriptable Object
    [SerializeField] private UpdateData updatesObject;  // Assets/Scripts/Scriptables/Data/UpdateData.cs
    // Serialize UI trackers
    [SerializeField] private TMP_Text notifText;        // Game Screen : CanvasGameScreen/UpdatesHolder/NotifBoundaryBox/TextBoundaryBox/TextNotifOne
    [SerializeField] private TMP_Text updatesText;      // Game Screen : CanvasGameScreen/UpdatesHolder/ItemBoundaryBox/TextUpdate
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
    void OnEnable()
    {UpdateData.OnUpdate += NewUpdates;}
    // Removes OnUpdate event listener for Update Data in the scene
    void OnDisable()
    {UpdateData.OnUpdate -= NewUpdates;}

    // Changes the contents of the Updates Tab based on the new values that Update Data receives
    void NewUpdates()
    {
        if (updatesObject.currentUpdate.isEvent) {playAudio.Play();}

        notifText.text = updatesObject.currentUpdate.updateDescription;
        updatesImage.sprite = Resources.Load<Sprite>($"{spriteLocation}/{updatesObject.currentUpdate.updateSpritePath}");
        updatesText.text = updatesObject.currentUpdate.updateFlavorText;
    }
}
