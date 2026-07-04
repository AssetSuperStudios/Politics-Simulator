using UnityEngine;
using UnityEngine.UI;

public class LocationSwap : MonoBehaviour
{
    [SerializeField] private Data playerData;
    [SerializeField] private Image locationSprite;
    private string initialPath = "Sprites/Locations/Backgrounds";

    public void LocationChange(int locationIndex)
    {
        playerData.LocationIndex = locationIndex;
        switch (locationIndex)
        {
            case (0):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/cloud");
                break;
            case (1):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/midnight");
                break;
            case (2):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/night");
                break;
            case (3):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/star");
                break;
            case (4):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/sun");
                break;
            case (5):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/sunrise");
                break;
            case (6):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/sunset");
                break;
            case (7):
                locationSprite.sprite = Resources.Load<Sprite>($"{initialPath}/twilight");
                break;
            default:
                Debug.LogError("Location index is out of range.");
                break;
        }
    }
}
