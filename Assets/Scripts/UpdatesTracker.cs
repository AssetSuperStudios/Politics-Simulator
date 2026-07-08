using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UpdatesTracker : MonoBehaviour
{
    [SerializeField] private UpdateData updatesObject;

    [SerializeField] private TMP_Text notifText;
    [SerializeField] private TMP_Text updatesText;
    [SerializeField] private Image updatesImage;

    private string spriteLocation = "Sprites/Icons/Updates";

    void OnEnable()
    {
        UpdateData.OnUpdate += NewUpdates;
    }

    void OnDisable()
    {
        UpdateData.OnUpdate -= NewUpdates;
    }

    void NewUpdates()
    {
        notifText.text = updatesObject.currentUpdate.updateDescription;
        updatesImage.sprite = Resources.Load<Sprite>($"{spriteLocation}/{updatesObject.currentUpdate.updateSpritePath}");
        updatesText.text = updatesObject.currentUpdate.updateFlavorText;
    }
}
