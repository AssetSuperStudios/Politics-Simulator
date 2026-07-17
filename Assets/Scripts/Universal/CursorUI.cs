// FRONT END

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
// Assets/Prefabs/ButtonActionPrefab.prefab [Universal]
// Assets/Prefabs/ButtonImgPrefab.prefab [Universal]
// Assets/Prefabs/ButtonTextPrefab.prefab [Universal]
// Assets/Prefabs/DropdownPrefab.prefab [Universal]
// Assets/Prefabs/SliderPrefab.prefab [Universal]
// Assets/Prefabs/TogglePrefab.prefab [Universal]
// Attach this to a Selectable Game Object that when hovered upon, changes the cursor sprite to what it wants

public class CursorUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    // Serialize the enum ModeOfCursor
    [SerializeField] private ModeOfCursor modeOfCursorHover;    // Creates a dropdown for the enum ModeOfCursor
    [SerializeField] private ModeOfCursor modeOfCursorClick;    // Creates a dropdown for the enum ModeOfCursor
    // Declare booleans and a SelectableUI game object that will be used for changing the cursor sprite
    private bool isHovering;
    private bool isClicking;
    private Selectable selectableUI;

    // Initializes the Selectable into the Game Object this script is attached to
    void Awake()
    {selectableUI = this.GetComponent<Selectable>();}

    // The on hover event
    public void OnPointerEnter(PointerEventData eventData)
    {
        // If it is not interactable then it is set to the disabled sprite
        // Otherwise, set isHovering to true
        // Change to hovering sprite
        if (!selectableUI.interactable)
        {CursorManager.Instance.SetToMode(ModeOfCursor.Disabled);}
        else
        {
            isHovering = true;
            CursorManager.Instance.SetToMode(modeOfCursorHover);
        }
    }

    // The stop hover event
    public void OnPointerExit(PointerEventData eventData)
    {
        // Set isHovering back to false
        isHovering = false;
        // If the user is currently not pressing down, then safely return the sprite back to default
        if (!isClicking)
        {CursorManager.Instance.SetToMode(ModeOfCursor.Default);}
    }

    // The on click event
    public void OnPointerDown(PointerEventData eventData)
    {
        // If it is interactable then set isClicking to true
        // And set the sprite to its clicking mode
        if (selectableUI.interactable)
        {
            isClicking = true;
            CursorManager.Instance.SetToMode(modeOfCursorClick);
        }
    }

    // The on release event
    public void OnPointerUp(PointerEventData eventData)
    {
        // If it is interactable then set isClicking to false
        // And check if the cursor isHovering
        // If it is, then set the sprite to its hover mode
        // Otherwise, set the sprite to the default sprite
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
