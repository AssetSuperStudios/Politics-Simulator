using UnityEngine;
using UnityEngine.UI;

public class LocationSwap : MonoBehaviour
{
    [SerializeField] private Data playerData;

    public void LocationChange(int locationIndex)
    {
        playerData.LocationIndex = locationIndex;
    }
}
