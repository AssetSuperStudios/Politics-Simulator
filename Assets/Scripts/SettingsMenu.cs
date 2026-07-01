
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    // Declaration of variables for an integer and boolean
    // For Fullscreen changing
    private int intFullscreen;
    private bool boolFullscreen;
    // For Screen Resultion changing
    private int currentResolution;
    // Serialize dropdown and toggle game objects
    [SerializeField] TMP_Dropdown dropdownScreen;
    [SerializeField] Toggle toggleScreen;
    // Serialized slider and audio mixer game objects;
    [SerializeField] Slider sliderMaster;
    [SerializeField] Slider sliderMusic;
    [SerializeField] Slider sliderSfx;
    [SerializeField] AudioMixer audiomixerSounds;

    // The following are the names of the PlayerPrefs used in this script
    // "isFullscreen", "resolutionIndex"
    // "volumeSoundMaster", "volumeSoundMusic", "volumeSoundSfx"
    // The following are the exposed parameters of the audio mixer
    // "Volume_Master", "Volume_Music", "Volume_Sfx"

    void Awake()
    {
        // FULL SCREEN
        // Get the fullscreen PlayerPref with the default as fullscreen
        // Sets the declared boolean to the corresponding integer value acquired
        intFullscreen = PlayerPrefs.GetInt("isFullscreen", 1);
        boolFullscreen = (intFullscreen == 1);

        // Change the toggle value based on the boolean
        toggleScreen.SetIsOnWithoutNotify(boolFullscreen);

        // SCREEN RESOLUTION
        // Get the resolution PlayerPref with the default as 1920 x 1080
        currentResolution = PlayerPrefs.GetInt("resolutionIndex", (int)0);

        // Change the dropdown value based on the value
        dropdownScreen.SetValueWithoutNotify(currentResolution);
        // Change screen resolution and screen fullness
        SetResolution(currentResolution);

        // AUDIO CHANGE
        // Adds an on value changed listener to each slider and binds the corresponding function to them
        sliderMaster.onValueChanged.AddListener(value => SetVolume(value, "Volume_Master", "volumeSoundMaster"));
        sliderMusic.onValueChanged.AddListener(value => SetVolume(value, "Volume_Music", "volumeSoundMusic"));
        sliderSfx.onValueChanged.AddListener(value => SetVolume(value, "Volume_Sfx", "volumeSoundSfx"));
    }

    // Note: Cannot be moved to Awake()
    // Sliders seem to get loaded in during Start() and not during Awake()
    void Start() {
        // AUDIO CHANGE
        // Get the PlayerPrefs for the respective sound value, with a default of 1 or max volume
        // Then set the slider and the volume to the acquired value
        sliderMaster.value = PlayerPrefs.GetFloat("volumeSoundMaster", (float)1);
        SetVolume(sliderMaster.value, "Volume_Master", "volumeSoundMaster");

        sliderMusic.value = PlayerPrefs.GetFloat("volumeSoundMusic", (float)1);
        SetVolume(sliderMusic.value, "Volume_Music", "volumeSoundMusic");

        sliderSfx.value = PlayerPrefs.GetFloat("volumeSoundSfx", (float)1);
        SetVolume(sliderSfx.value, "Volume_Sfx", "volumeSoundSfx");
    }

    // AUDIO CHANGE
    void SetVolume(float sliderValue, string audioMixer, string prefString)
    {
        // Converts the linear 0.1 to 1 value of the slider to the logarithmic change of the audio (multiplied by 20)
        // Then change the corresponding PlayerPref to the new value
        audiomixerSounds.SetFloat(audioMixer, Mathf.Log10(sliderValue) * 20);

        PlayerPrefs.SetFloat(prefString, sliderValue);
    }

    // FULL SCREEN
    // Add OnValueChanged component on the toggleScreen GameObject
    // Drag the GameObject that has this script to the GameObject Tab in the Inspector
    // Select the SetFullscreen function (as Dynamic bool)
    // The initial parameter must be empty
    public void SetFullscreen(bool isFullscreen)
    {
        // Set the boolean to the toggle's value
        // This is needed to be updated since the SetResolution method requires the isFullScreen boolean as paramter
        // Finally, set the screen to full screen based on the boolean parameter
        boolFullscreen = isFullscreen;
        Screen.fullScreen = isFullscreen;

        // Convert the boolean to integer with 1 = true and 0 = false
        // Save the new toggle value as PlayerPrefs
        intFullscreen = (isFullscreen) ? 1 : 0;
        PlayerPrefs.SetInt("isFullscreen", (int)intFullscreen);
    }

    // SCREEN RESOLUTION
    // Add OnValueChanged component on the dropdownScreen GameObject
    // Drag the GameObject that has this script to the GameObject Tab in the Inspector
    // Select the SetResolution function (as Dynamic int)
    // The initial parameter must be empty
    public void SetResolution(int resolutionIndex)
    {
        // Change screen resolution based on the dropdown index parameter
        switch (resolutionIndex)
        {
            // 16:9
            case 0:
                Screen.SetResolution(1920, 1080, boolFullscreen);
                break;
            // 8:5
            case 1:
                Screen.SetResolution(1440, 900, boolFullscreen);
                break;
            // 4:3
            case 2:
                Screen.SetResolution(800, 600, boolFullscreen);
                break;
            // Fallback debugging
            default:
                Debug.LogError($"The index for the Dropdown is out of bounds, received the value of {resolutionIndex}");
                break;
        }

        // Save the new value as PlayerPrefs
        PlayerPrefs.SetInt("resolutionIndex", (int)resolutionIndex);
    }

    // BUTTONS
    // Open a specific Settings Tab
    // Changes Canvas Group properties
    public void OpenTab(CanvasGroup canvasTab)
    {
        canvasTab.alpha = 1;
        canvasTab.interactable = true;
        canvasTab.blocksRaycasts = true;
    }

    // BUTTONS
    // Close a specific Settings Tab
    // Changes Canvas Group properties
    // Permanently saves all changed PlayerPrefs to the registry instead of doing it temporarily
    public void CloseTab(CanvasGroup canvasTab)
    {
        canvasTab.alpha = 0;
        canvasTab.interactable = false;
        canvasTab.blocksRaycasts = false;
        PlayerPrefs.Save();
    }
}
