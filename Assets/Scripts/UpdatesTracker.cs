using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Threading.Tasks;

public class UpdatesTracker : MonoBehaviour
{
    [SerializeField] private UpdateData updatesObject;

    [SerializeField] private TMP_Text notifText;
    [SerializeField] private TMP_Text updatesText;
    [SerializeField] private Image updatesImage;

    private string spriteLocation = "Sprites/Icons/Updates";

    void Start()
    {
        NewUpdates();
    }

    void OnEnable()
    {
        UpdateData.OnUpdate += NewUpdates;
    }

    void OnDisable()
    {
        UpdateData.OnUpdate -= NewUpdates;
    }

    async void NewUpdates()
    {
        updatesImage.sprite = Resources.Load<Sprite>($"{spriteLocation}/{updatesObject.currentUpdate.updateSpritePath}");
        updatesText.text = updatesObject.currentUpdate.updateFlavorText;
        await Task.Delay(6000);
        notifText.text = updatesObject.currentUpdate.updateDescription;
    }
}
