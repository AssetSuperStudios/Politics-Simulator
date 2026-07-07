using UnityEngine;

public class GameCondition : MonoBehaviour
{
    [SerializeField] private Data playerData;
    void Awake()
    {
        CheckCondition();
    }

    // Update is called once per frame
    void Update()
    {
        CheckSafety();
        CheckSatisfaction();
        CheckBudget();
    }

    void CheckCondition()
    {
        if (playerData.LoseStatus != 0)
        {
            Debug.Log("You lost the game!");
            FindAnyObjectByType<SceneSwap>().SceneSwapper("Lose Scene");
            CalendarTick.isPaused = true;
        }
    }

    void CheckSafety()
    {
        float maxMoney = 1000000000f;
        float maxMilitary = 5000f;

        float currentMoney = Mathf.Clamp(playerData.MoneyValue, 0f, maxMoney);
        float currentMilitary = Mathf.Clamp(playerData.MilitaryValue, 1f, maxMilitary);

        float moneyLog = Mathf.Log10(currentMoney + 1f);
        float maxMoneyLog = Mathf.Log10(maxMoney + 1f);
        float moneyPercentage = moneyLog / maxMoneyLog;
        float militaryPercentage = currentMilitary / maxMilitary;

        float lowSafetyScore = (moneyPercentage + (1f - militaryPercentage)) / 2f;

        playerData.SafetyPercentage = Mathf.Clamp(Mathf.RoundToInt(lowSafetyScore * 3f), 0, 3);

        int safetyThreshold = 0;
        switch (playerData.ClassName)
        {
            case "Mayor":
            case "Governor":
                safetyThreshold = 3;
                break;
            case "Congress":
            case "Senator":
                safetyThreshold = 2;
                break;
            case "VP":
            case "President":
                safetyThreshold = 1;
                break;
        }

        if (playerData.SafetyPercentage >= safetyThreshold)
        {
            Debug.Log($"Lost due to poor safety! Level: {playerData.SafetyPercentage}/3 (Threshold: {safetyThreshold})");
            playerData.LoseStatus = 2;
            LoseCondition("safety");
        }
    }

    void CheckSatisfaction()
    {
        float maxMoney = 1000000000f; // 1 Trillion
        float maxInfluence = 680f;

        float currentMoney = Mathf.Clamp(playerData.MoneyValue, 0f, maxMoney);
        float currentInfluence = Mathf.Clamp(playerData.InfluenceValue, 1f, maxInfluence);

        float moneyLog = Mathf.Log10(currentMoney + 1f);
        float maxMoneyLog = Mathf.Log10(maxMoney + 1f);
        float moneyPercentage = moneyLog / maxMoneyLog;
        float influencePercentage = currentInfluence / maxInfluence;

        float lowSatisfactionScore = (moneyPercentage + (1f - influencePercentage)) / 2f;
        playerData.SatisfactionPercentage = Mathf.Clamp(Mathf.RoundToInt(lowSatisfactionScore * 4f), 0, 4);

        int satisfactionThreshold = 0;
        switch (playerData.ClassName)
        {
            case "Mayor":
            case "Governor":
                satisfactionThreshold = 4;
                break;
            case "Congress":
            case "Senator":
                satisfactionThreshold = 3;
                break;
            case "VP":
            case "President":
                satisfactionThreshold = 2;
                break;
        }

        if (playerData.SatisfactionPercentage >= satisfactionThreshold)
        {
            Debug.Log("You lost the game due to low satisfaction!");
            playerData.LoseStatus = 3;
            LoseCondition("satisfaction");
        }
    }

    void CheckBudget()
    {
        if (playerData.MoneyValue <= 0)
        {
            Debug.Log("You lost the game due to low budget!");
            playerData.LoseStatus = 4;
            LoseCondition("budget");
        }
    }

    void CheckWinCondition()
    {
        if (playerData.ClassName == "President" && playerData.InfluenceValue >= 680 && playerData.MoneyValue >= 1000000000f)
        {
            Debug.Log("You won the game!");
            WinCondition("greed");
        }
    }

    public void LoseCondition(string condition)
    {
        Debug.Log($"Lose Condition triggered due to {condition}.");
        FindAnyObjectByType<SceneSwap>().SceneSwapper("Lose Scene");
        CalendarTick.isPaused = true;
    }

    public void WinCondition(string condition)
    {
        Debug.Log($"Win Condition triggered due to {condition}.");
        FindAnyObjectByType<SceneSwap>().SceneSwapper("Win Scene");
        CalendarTick.isPaused = true;
    }
}
