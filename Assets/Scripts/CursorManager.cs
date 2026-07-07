using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public static CursorManager Instance { get; private set; }

    [SerializeField] private Texture2D cursorDefault;
    [SerializeField] private Texture2D cursorDisabled;
    [SerializeField] private Texture2D buttonHover;
    [SerializeField] private Texture2D buttonClick;
    [SerializeField] private Texture2D actionHover;
    [SerializeField] private Texture2D actionClick;
    [SerializeField] private Texture2D locationHover;
    [SerializeField] private Texture2D locationClick;
    [SerializeField] private Texture2D sliderHover;
    [SerializeField] private Texture2D sliderClick;
    [SerializeField] private Vector2 clickPosition = Vector2.zero;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Cursor.SetCursor(cursorDefault, clickPosition, CursorMode.Auto);
    }

    public void SetToMode(ModeOfCursor modeOfCursor)
    {
        switch(modeOfCursor)
        {
            case (ModeOfCursor.Default):
                Cursor.SetCursor(cursorDefault, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.Disabled):
                Cursor.SetCursor(cursorDisabled, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.ButtonHover):
                Cursor.SetCursor(buttonHover, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.ButtonClick):
                Cursor.SetCursor(buttonClick, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.ActionHover):
                Cursor.SetCursor(actionHover, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.ActionClick):
                Cursor.SetCursor(actionClick, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.LocationHover):
                Cursor.SetCursor(locationHover, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.LocationClick):
                Cursor.SetCursor(locationClick, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.SliderHover):
                Cursor.SetCursor(sliderHover, clickPosition, CursorMode.Auto);
                break;
            case (ModeOfCursor.SliderClick):
                Cursor.SetCursor(sliderClick, clickPosition, CursorMode.Auto);
                break;
            default:
                Debug.LogError($"{modeOfCursor}, that type of cursor does not exist.");
                break;
        }
    }
}

// Global access
public enum ModeOfCursor
{
    Default,
    ButtonHover,
    ButtonClick,
    ActionHover,
    ActionClick,
    LocationHover,
    LocationClick,
    SliderHover,
    SliderClick,
    Disabled
}