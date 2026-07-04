using UnityEngine;
using UnityEngine.UI;
public class PlayerSaveChecker : MonoBehaviour
{
    [SerializeField] private Data playerData;
    [SerializeField] private CharacterStats selectedCharacter;

    void Start()
    {
        if (playerData.NewSave)
        {
            var path = $"Sprites/Icons/Safety/{selectedCharacter.stringPath}/0";
            var transitionSprites = gameObject.GetComponent<Button>().spriteState;

            gameObject.GetComponent<Button>().interactable = true;
            transitionSprites.highlightedSprite = Resources.Load<Sprite>(path);
            transitionSprites.pressedSprite = Resources.Load<Sprite>(path);

            gameObject.GetComponent<Button>().spriteState = transitionSprites;
        }
    }
}
