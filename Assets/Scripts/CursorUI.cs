using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CursorUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private ModeOfCursor modeOfCursorHover;
    [SerializeField] private ModeOfCursor modeOfCursorClick;
    
    private bool isHovering;
    private bool isClicking;
    private Selectable selectableUI;

    void Awake()
    {
        selectableUI = this.GetComponent<Selectable>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!selectableUI.interactable)
        {CursorManager.Instance.SetToMode(ModeOfCursor.Disabled);}
        else
        {
            isHovering = true;
            CursorManager.Instance.SetToMode(modeOfCursorHover);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
        if (!isClicking)
        {CursorManager.Instance.SetToMode(ModeOfCursor.Default);}
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (selectableUI.interactable)
        {
            isClicking = true;
            CursorManager.Instance.SetToMode(modeOfCursorClick);
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (selectableUI.interactable)
        {
            isClicking = false;
            if(isHovering) 
            {CursorManager.Instance.SetToMode(modeOfCursorHover);}
            else
            {CursorManager.Instance.SetToMode(ModeOfCursor.Default);}
        }
    }
}
