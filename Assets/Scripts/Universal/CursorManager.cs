// FRONT END

using UnityEngine;
// Assets/Prefabs/MainCameraPrefab.prefab [Universal]
// Attach this to the GameObject that when hovered upon, sets the Action Panel contents

public class CursorManager : MonoBehaviour
{
    // 
    public static CursorManager Instance { get; private set; }

    // Serialize Sprites and a Vector2
    [SerializeField] private Texture2D cursorDefault;               // Assets/Resources/Sprites/UI/Cursor/Default.PNG
    [SerializeField] private Texture2D cursorDisabled;              // Assets/Resources/Sprites/UI/Cursor/Disabled.PNG
    [SerializeField] private Texture2D buttonHover;                 // Assets/Resources/Sprites/UI/Cursor/ButtonHover.PNG
    [SerializeField] private Texture2D buttonClick;                 // Assets/Resources/Sprites/UI/Cursor/ButtonClick.PNG
    [SerializeField] private Texture2D actionHover;                 // Assets/Resources/Sprites/UI/Cursor/ActionHover.PNG
    [SerializeField] private Texture2D actionClick;                 // Assets/Resources/Sprites/UI/Cursor/ActionClick.PNG
    [SerializeField] private Texture2D locationHover;               // Assets/Resources/Sprites/UI/Cursor/LocationHover.PNG
    [SerializeField] private Texture2D locationClick;               // Assets/Resources/Sprites/UI/Cursor/LocationClick.PNG
    [SerializeField] private Texture2D sliderHover;                 // Assets/Resources/Sprites/UI/Cursor/SliderHover.PNG
    [SerializeField] private Texture2D sliderClick;                 // Assets/Resources/Sprites/UI/Cursor/SliderClick.PNG
    [SerializeField] private Vector2 clickPosition = Vector2.zero;  // Initializes mouse position at <0,0>

    // Ensures the GameObject this script is attached to is passed from scene to scene
    // This gets destroyed if there is already another copy of this Game Object in the new scene
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {Destroy(gameObject);}
    }

    // Sets the cursor to the default sprite
    // Note: CursorMode has two values: Auto and ForceSoftware
    // From the Unity documentation:
    //      (1) Use hardware cursors on supported platforms
    //      (2) Force the use of software cursors
    void Start()
    {Cursor.SetCursor(cursorDefault, clickPosition, CursorMode.Auto);}

    // Gets called by CursorUI script
    // Sets the sprite of the cursor based on the parameter passed
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

// Can be globally accessed by any script
// An enum, pertaining to each available cursor modes
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