using UnityEngine;
using System.Collections.Generic;

public class GameActionsManager : MonoBehaviour
{
    [SerializeField] private Data playerData;
    [SerializeField] private Actions actionsReference;
    private List<GameAction> tempList = new List<GameAction>();
    
    void Start()
    {
        InitializeActions();
    }

    void InitializeActions()
    {
        tempList.Add(new GameAction
        {
            actionName = "Build Farm",
            actionSpritePath = "build_farm",
            resourceMilitary = 50,
            resourceInfluence = 20,
            resourceMoney = 100,
            actionDescription = "Construct a farm to increase food production.",
            actionFunctionCall = BuildFarm
        });
        tempList.Add(new GameAction
        {
            actionName = "Build Barracks",
            actionSpritePath = "build_barracks",
            resourceMilitary = 100,
            resourceInfluence = 30,
            resourceMoney = 200,
            actionDescription = "Construct a barracks to train soldiers.",
            actionFunctionCall = BuildBarracks
        });
        tempList.Add(new GameAction
        {
            actionName = "Upgrade Castle",
            actionSpritePath = "upgrade_castle",
            resourceMilitary = 200,
            resourceInfluence = 50,
            resourceMoney = 500,
            actionDescription = "Upgrade the castle to increase its defenses.",
            actionFunctionCall = UpgradeCastle
        });
        tempList.Add(new GameAction
        {
            actionName = "Build Wall",
            actionSpritePath = "build_wall",
            resourceMilitary = 10,
            resourceInfluence = 10,
            resourceMoney = 10,
            actionDescription = "Construct a wall to increase defenses.",
            actionFunctionCall = BuildWall
        });
        tempList.Add(new GameAction
        {
            actionName = "Hire Soldiers",
            actionSpritePath = "hire_soldiers",
            resourceMilitary = 0,
            resourceInfluence = 20,
            resourceMoney = 100,
            actionDescription = "Hire soldiers to strengthen your army.",
            actionFunctionCall = HireSoldiers
        });
        tempList.Add(new GameAction
        {
            actionName = "Build Mine",
            actionSpritePath = "build_mine",
            resourceMilitary = 50,
            resourceInfluence = 20,
            resourceMoney = 100,
            actionDescription = "Construct a mine to increase resource production.",
            actionFunctionCall = BuildMine
        });
        tempList.Add(new GameAction
        {
            actionName = "Assign Workers",
            actionSpritePath = "assign_workers",
            resourceMilitary = 0,
            resourceInfluence = 80,
            resourceMoney = 100,
            actionDescription = "Assign workers to increase food production.",
            actionFunctionCall = AssignWorkers
        });
        tempList.Add(new GameAction
        {
            actionName = "Start Trade",
            actionSpritePath = "start_trade",
            resourceMilitary = 50,
            resourceInfluence = 200,
            resourceMoney = 0,
            actionDescription = "Start trading to increase wealth.",
            actionFunctionCall = StartTrade
        });
        
        actionsReference.ActionList = tempList;
    }

    // Function calls for the GameAction initialized
    // Must return true or false whether the action was successful or not (based on resources/requirements)
    bool BuildFarm()
    {
        Debug.Log("Building a farm...");
        playerData.ClassName = "Governor";
        return true;
    }
    bool BuildBarracks()
    {
        Debug.Log("Building a barracks...");
        playerData.TimeDay = 356;
        return true;
    }
    bool UpgradeCastle()
    {
        Debug.Log("Upgrading the castle...");
        playerData.MoneyValue = 100000;
        return true;
    }
    bool BuildWall()
    {
        Debug.Log("Building a wall...");
        playerData.SatisfactionPercentage = 4;
        return true;
    }
    bool HireSoldiers()
    {
        Debug.Log("Hiring soldiers...");
        playerData.MilitaryValue = 80;
        return true;
    }
    bool BuildMine()
    {
        Debug.Log("Building a mine...");
        playerData.SafetyPercentage = 3;
        return true;
    }
    bool AssignWorkers()
    {
        Debug.Log("Assigning workers...");
        playerData.LoseStatus = true;
        return false;
    }
    bool StartTrade()
    {
        Debug.Log("Starting trade...");
        playerData.InfluenceValue = 200;
        return true;
    }
}
