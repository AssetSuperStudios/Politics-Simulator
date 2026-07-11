// FRONT END

using UnityEngine;
// Game Screen : CanvasGameScreen/UpdatesHolder/NotifBoundaryBox/BackgroundAnimated
// Game Screen : CanvasGameScreen/UpdatesHolder/NotifBoundaryBox/MascotAnimated
// Attach this to the GameObject that needs to be animated based on the Karma value
// [TASK]
// Add an OnEnable and OnDisable calls for Data.OnKarmaChange which calls SetActiveLayer
// Change SetActiveLayer to receive the value of Karma and change the layers based on that

public class AnimationController : MonoBehaviour
{
    // Declare the Animator and layerIndeces used
    private Animator spriteAnimator;
    private int baseLayerIndex;
    private int shadeLayerIndex;
    private int corruptLayerIndex;

    // Initialize the Animator and layerIndeces at the start
    void Start()
    {
        spriteAnimator = GetComponent<Animator>();
        baseLayerIndex = spriteAnimator.GetLayerIndex("Base Layer");
        shadeLayerIndex = spriteAnimator.GetLayerIndex("Shadow Layer");
        corruptLayerIndex = spriteAnimator.GetLayerIndex("Corrupted Layer");
    }

    // Sets up OnUpdate event listener for the Updates in the scene
    // Calls PlayAnimation()
    void OnEnable()
    {UpdateData.OnUpdate += PlayAnimation;}
    // Removes up OnUpdate event listener for the Updates in the scene
    // Calls PlayAnimation()
    void OnDisable()
    {UpdateData.OnUpdate -= PlayAnimation;}

    // Triggers any animation transition with value PlayTwice
    void PlayAnimation()
    {spriteAnimator.SetTrigger("PlayTwice");}

    // Currently called on a button click
    // Changes the active animation layer based on the parameter it receives
    public void SetActiveLayer(int layerIndex)
    {
        switch (layerIndex) {
            case (0):
                spriteAnimator.SetLayerWeight(baseLayerIndex, 1f);
                spriteAnimator.SetLayerWeight(shadeLayerIndex, 0f);
                spriteAnimator.SetLayerWeight(corruptLayerIndex, 0f);
                break;
            case (1):
                spriteAnimator.SetLayerWeight(baseLayerIndex, 0f);
                spriteAnimator.SetLayerWeight(shadeLayerIndex, 1f);
                spriteAnimator.SetLayerWeight(corruptLayerIndex, 0f);
                break;
            case (2):
                spriteAnimator.SetLayerWeight(baseLayerIndex, 0f);
                spriteAnimator.SetLayerWeight(shadeLayerIndex, 0f);
                spriteAnimator.SetLayerWeight(corruptLayerIndex, 1f);
                break;
            default:
                Debug.LogWarning("Incorrect animation layer index");
                break;
        }
    }
}
