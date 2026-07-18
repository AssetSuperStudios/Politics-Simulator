// FRONT END

using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
// Game Screen : CanvasGameScreen/CampaignHolder
// Attach this to the GameObject that acts as the Canvas pop up

// TEMP TESTING //
[System.Serializable]
public struct Campaign
{
    public int militaryRank;
    public int influenceRank;
    public int moneyRank;
    public int overallRank;

    public void SetData(int militaryRank, int influenceRank, int moneyRank, int overallRank)
    {
        this.militaryRank = militaryRank;
        this.influenceRank = influenceRank;
        this.moneyRank = moneyRank;
        this.overallRank = overallRank;
    }
}
// TEMP TESTING //

public class CampaignTracker : MonoBehaviour
{
    // TEMP TESTING //
    public Campaign newCampaign;
    // TEMP TESTING //

    // Hide the Campaign Pop Up at the start
    void Start()
    {
        // Initialize the Canvas Group component of the Game Object
        CanvasGroup campaignCanvas = GetComponent<CanvasGroup>();

        // Hide the Canvas Group
        campaignCanvas.alpha = 0;
        campaignCanvas.interactable = false;
        campaignCanvas.blocksRaycasts = false;

        // TEMP TESTING //
        // Set the values of the campaign
        int military = Random.Range(1, 5);
        int influence = Random.Range(1, 5);
        int money = Random.Range(1, 5);
        int overall = Random.Range(1, 5);

        newCampaign.SetData(military, influence, money, overall);
        // TEMP TESTING //
    }

    // Sets up OnChange event listener for Update Data in the scene
    // Calls CampaignStart()
    void OnEnable()
    {// UpdateData.OnUpdate += CampaignStart;
    }
    // Removes OnChange event listener for Update Data in the scene
    // Calls CampaignStart()
    void OnDisable()
    {// UpdateData.OnUpdate -= CampaignStart;
    }

    // Reveals the Campaign Pop Up when called
    public void CampaignStart()
    // void CampaignStart()
    {
        // Play audio
        AudioSource campaignAudio = GetComponent<AudioSource>();
        campaignAudio.Play();

        // Initialize the Canvas Group component of the Game Object
        CanvasGroup campaignCanvas = GetComponent<CanvasGroup>();

        // Declare each UI
        TMP_Text textMilitary = campaignCanvas.transform.Find("RankingsHolder/ResourcesHolder/MilitaryHolder/TextRank").GetComponent<TMP_Text>();
        TMP_Text textInfluence = campaignCanvas.transform.Find("RankingsHolder/ResourcesHolder/InfluenceHolder/TextRank").GetComponent<TMP_Text>();
        TMP_Text textMoney = campaignCanvas.transform.Find("RankingsHolder/ResourcesHolder/MoneyHolder/TextRank").GetComponent<TMP_Text>();
        TMP_Text textOverall = campaignCanvas.transform.Find("RankingsHolder/OverallHolder/TextRank").GetComponent<TMP_Text>();
        // Change the contents of the UI
        textMilitary.text = $"#{newCampaign.militaryRank}";
        textInfluence.text = $"#{newCampaign.influenceRank}";
        textMoney.text = $"#{newCampaign.moneyRank}";
        textOverall.text = $"#{newCampaign.overallRank}";

        // Reveal the Canvas Group
        campaignCanvas.alpha = 1;
        campaignCanvas.interactable = true;
        campaignCanvas.blocksRaycasts = true;
    }
}
