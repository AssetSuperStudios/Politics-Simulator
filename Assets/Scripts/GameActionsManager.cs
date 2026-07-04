using UnityEngine;
using System.Collections.Generic;

public class GameActionsManager : MonoBehaviour
{
    [SerializeField] private Data playerData;
    [SerializeField] private CharacterStats selectedCharacter;
    [SerializeField] private Actions actionsReference;
    public CalendarTick calendarTick;

    private List<GameAction> tempList = new List<GameAction>();
    private float lastExecutionTime = 0f;
    [SerializeField] private float spamCooldown = 0.25f;

    // Awake guarantees registration before CreatePane looks up the list data
    void Awake()
    {
        InitializeActions();
    }

    void InitializeActions()
    {
        tempList.Clear();

        // One-line structural registration for every choice card
        AddAction(
            "Build Farm", "build_farm", 50, 20, 100, 1, "Construct a farm to increase food production.");
        AddAction(
            "Build Barracks", "build_barracks", 100, 30, 200, 1, "Construct a barracks to train soldiers.");
        AddAction(
            "Upgrade Castle", "upgrade_castle", 200, 50, 500, 1, "Upgrade the castle to increase its defenses.");
        AddAction(
            "Build Wall", "build_wall", 10, 10, 10, 1, "Construct a wall to increase defenses.");
        AddAction(
            "Hire Soldiers", "hire_soldiers", 0, 20, 100, 1, "Hire soldiers to strengthen your army.");
        AddAction(
            "Build Mine", "build_mine", 50, 20, 100, 1, "Construct a mine to increase resource production.");
        AddAction(
            "Assign Workers", "assign_workers", 0, 80, 100, 1, "Assign workers to increase food production.");
        AddAction(
            "Start Trade", "start_trade", 50, 200, 0, 1, "Start trading to increase wealth.");

        actionsReference.ActionList = tempList;
    }

    // Helper method: Packs construction, structural tracking, and runtime lambda routing into a single line
    private void AddAction(string name, string sprite, int mil, int inf, int mon, int time, string desc)
    {
        GameAction act = new GameAction
        {
            actionName = name,
            actionSpritePath = sprite,
            resourceMilitary = mil,
            resourceInfluence = inf,
            resourceMoney = mon,
            resourceTime = time,
            actionDescription = desc
        };

        // Capture scope reference perfectly so clicking maps dynamically to the generalized pipeline
        act.actionFunctionCall = () => ExecuteActionPipeline(act);
        tempList.Add(act);
    }

    // Single unified point of execution replaces all 8 custom named functions
    private bool ExecuteActionPipeline(GameAction action)
    {
        // Spam prevention: If the last execution was too recent, drop the action and log a warning
        if (Time.time < lastExecutionTime + spamCooldown)
        {
            Debug.LogWarning("Action submission dropped: Input spam tracking filter triggered.");
            return false;
        }

        // Check if player has enough resources to execute the action
        if (playerData.MilitaryValue < action.resourceMilitary ||
            playerData.InfluenceValue < action.resourceInfluence ||
            playerData.MoneyValue < action.resourceMoney)
        {
            Debug.LogWarning($"Cannot execute {action.actionName}: Insufficient resources available!");
            return false; // Returns false so CreatePane leaves the panel on screen
        }

        lastExecutionTime = Time.time;
        Debug.Log($"Executing action: {action.actionName}...");

        // Resource modification pipeline: Apply character-specific modifiers to the base action values
        playerData.MilitaryValue += (int)(action.resourceMilitary * selectedCharacter.percentageMilitaryModifier);
        if (playerData.InfluenceValue + (int)(action.resourceInfluence * selectedCharacter.percentageInfluenceModifier) > DataTracker.maxInfluence)
        {
            playerData.InfluenceValue = DataTracker.maxInfluence;
        }
        else
        {
            playerData.InfluenceValue += (int)(action.resourceInfluence * selectedCharacter.percentageInfluenceModifier);
        }
        playerData.MoneyValue += (int)(action.resourceMoney * selectedCharacter.percentageMoneyModifier);

        // 3. Sequential Time Clock Management Pipeline
        if (calendarTick != null)
        {
            calendarTick.DayPassed(action.resourceTime);
        }
        else
        {
            Debug.LogError("CalendarTick runtime script instance reference missing from manager inspector slot!");
        }

        return true;
    }
}