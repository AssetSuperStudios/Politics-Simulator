using UnityEngine;
using TMPro;

public class LoseScene : MonoBehaviour
{
    [SerializeField] private TMP_Text textDescription;
    [SerializeField] private Data playerData;
    [SerializeField] private Data lastPlayerData;
    
	void Start()
    {
        CheckLoseCondition();
    }


    void LoadLastPlayerData()
    {
        playerData.ClassName = lastPlayerData.ClassName;
        playerData.MoneyValue = lastPlayerData.MoneyValue;
        playerData.MilitaryValue = lastPlayerData.MilitaryValue;
        playerData.InfluenceValue = lastPlayerData.InfluenceValue;
        playerData.SatisfactionPercentage = lastPlayerData.SatisfactionPercentage;
        playerData.SafetyPercentage = lastPlayerData.SafetyPercentage;
        playerData.TimeDay = lastPlayerData.TimeDay;
        playerData.LoseStatus = 0;
        playerData.LocationIndex = lastPlayerData.LocationIndex;
    }

    void CheckLoseCondition()
    {
        if (playerData.LoseStatus == 0) return;

        if (playerData.LoseStatus == 1)
        {
            textDescription.text = "You lost the election!";
        }
        else if (playerData.LoseStatus == 2)
        {
            textDescription.text = "You died from assassination!";
        }
        else if (playerData.LoseStatus == 3)
        {
            textDescription.text = "Your government was overthrown!";
        }
        else if (playerData.LoseStatus == 4)
        {
            textDescription.text = "You lost all budget!";
        }
        else
        {
            textDescription.text = "You lost the game!";
        }

        textDescription.text += "\nTry again from last class (left) or completely restart (right)?";

        LoadLastPlayerData();
    }
}
