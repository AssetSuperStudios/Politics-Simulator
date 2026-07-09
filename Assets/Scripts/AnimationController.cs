using UnityEngine;
using System.Threading.Tasks;

public class AnimationController : MonoBehaviour
{
    private Animator spriteAnimator;
    private int layerIndex;
    void Start()
    {
        spriteAnimator = GetComponent<Animator>();
        layerIndex = spriteAnimator.GetLayerIndex("Corrupted Layer");
    }

    void OnEnable()
    {
        UpdateData.OnUpdate += PlayAnimation;
    }

    void OnDisable()
    {
        UpdateData.OnUpdate -= PlayAnimation;
    }

    // Update is called once per frame
    async void PlayAnimation()
    {
        await Task.Delay(2000);
        spriteAnimator.SetTrigger("PlayTwice");
    }

    public void ActivateMotionLayer()
    {
        spriteAnimator.SetLayerWeight(layerIndex, 1f);
    }

    public void DeactivateMotionLayer()
    {
        spriteAnimator.SetLayerWeight(layerIndex, 0f);
    }
}
