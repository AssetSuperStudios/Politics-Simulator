using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableUI : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] public GameObject parentObject;

    private RectTransform panelTransform;
    private bool dragStatus;

    [SerializeField] private ModeOfCursor modeOfCursorHover;
    [SerializeField] private ModeOfCursor modeOfCursorClick;

    private bool isHovering;

    void Start()
    {
        this.panelTransform = GetComponent<RectTransform>();
        dragStatus = true;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        dragStatus = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Check if dragging is allowed
        if (!dragStatus) return;

        // Initialize the RectTransform of the parent object to calculate boundaries
        var renderer = parentObject.GetComponent<RectTransform>();

        // Calculate mouse movement
        Vector2 newPosition = panelTransform.anchoredPosition + eventData.delta / (Vector2)parentObject.transform.localScale;

        // Calculate boundaries in local space
        // Reduces the parent boundaries based on the panel size and where its pivot is located
        float parentWidth = renderer.rect.width;
        float parentHeight = renderer.rect.height;

        float panelWidth = panelTransform.rect.width;
        float panelHeight = panelTransform.rect.height;

        float minX = ( 0 - (parentWidth * renderer.pivot.x) ) + ( panelWidth * panelTransform.pivot.x );
        float maxX = ( parentWidth * (1 - renderer.pivot.x) ) - ( panelWidth * (1 - panelTransform.pivot.x) );
        
        float minY = ( 0 - (parentHeight * renderer.pivot.y) ) + ( panelHeight * panelTransform.pivot.y );
        float maxY = ( parentHeight * (1 - renderer.pivot.y) ) - ( panelHeight * (1 - panelTransform.pivot.y) );

        // Clamp the position to the bottom-left boundary
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        panelTransform.anchoredPosition = newPosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!dragStatus) return;
        dragStatus = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isHovering = true;
        CursorManager.Instance.SetToMode(modeOfCursorHover);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isHovering = false;
        CursorManager.Instance.SetToMode(ModeOfCursor.Default);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        CursorManager.Instance.SetToMode(modeOfCursorClick);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if(isHovering) 
        {CursorManager.Instance.SetToMode(modeOfCursorHover);}
        else
        {CursorManager.Instance.SetToMode(ModeOfCursor.Default);}
        
    }
}
