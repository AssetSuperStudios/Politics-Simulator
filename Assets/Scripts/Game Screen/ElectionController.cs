using UnityEngine;
using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;

public class ElectionController : MonoBehaviour
{
    // Serialize Candidate Prefab
    [SerializeField] private GameObject candidatePrefab;
    // Declare the Canvas Group component, the Game Object list for each candidate, and its child Texts and Images
    private CanvasGroup canvasGroup;
    private GameObject[] candidateList;
    private TMP_Text textMilitary;
    private TMP_Text textInfluence;
    private TMP_Text textMoney;
    private RectTransform barMilitary;
    private RectTransform barInfluence;
    private RectTransform barMoney;

    // Assign the Canvas Group component when the object loads
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Sets up OnSomethingChange event listener for the Election in the scene
    void OnEnable()
    {// OnSomethingChange += ElectionStart();
    }
    // Removes OnSomethingChange event listener for the Election in the scene
    void OnDisable()
    {// OnSomethingChange += ElectionStart();
    }

    // 
    void ElectionStart()
    {
        // Clear all existing election UI elements before displaying new ones
        foreach (Transform child in transform)
        {Destroy(child.gameObject);}

        // Get list of candidates
        // Either set candidate list here OR Serialize candidate list and set it in the Inspector

        // Create a list container for the coroutines
        List<IEnumerator> coroutineList = new List<IEnumerator>();

        // Get the overall max values for each resource in the list
        var maxMilitary = candidateList.Max(obj => obj.militaryValue);
        var maxInfluence = candidateList.Max(obj => obj.influenceValue);
        var maxMoney = candidateList.Max(obj => obj.moneyValue);

        // Create a Candidate for each one in the list
        foreach (var candidate in candidateList)
        {
            // Instantiate new Candidate
            GameObject newCandidate = Instantiate(candidatePrefab, transform.Find("MembersHolder"));
            // Change the candidate's character sprite
            // newCandidate.transform.Find("ImageCandidate").GetComponent<Image>().sprite = Resources.Load<Sprite>($"{candidate.spritePath}");
            // Initialize the coroutine and save them
            coroutineList.Add(ElectionAnimate(newCandidate, candidate.militaryValue, candidate.influenceValue, candidate.moneyValue, maxMilitary, maxInfluence, maxMoney));
        }

        // Show the Game Object when the election starts
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

        // Start coroutine animation of the elements
        foreach (var coroutine in coroutineList)
        {StartCoroutine(coroutine);}
    }

    // Animate the resource bar and the texts
    IEnumerator ElectionAnimate(GameObject candidateInterface, int militaryValue, int influenceValue, int moneyValue, int militaryMax, int influenceMax, int moneyMax)
    {
        // Animation variables
        float duration = 6f;
        float elapsed = 0f;

        // Find Text Objects
        textMilitary = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/TextMilitary").GetComponent<TMP_Text>();
        textInfluence = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/TextInfluence").GetComponent<TMP_Text>();
        textMoney = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/TextMoney").GetComponent<TMP_Text>();
        // Find Image Objects
        barMilitary = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/ImageMilitary").GetComponent<RectTransform>();
        barInfluence = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/ImageInfluence").GetComponent<RectTransform>();
        barMoney = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/ImageMoney").GetComponent<RectTransform>();

        // Calculate target anchor heights
        float targetMilitary = (float)militaryValue / militaryMax;
        float targetInfluence = (float)influenceValue / influenceMax;
        float targetMoney = (float)moneyValue / moneyMax;
        // Store initial anchor values
        Vector2 currentMilitary = barMilitary.anchorMax;
        Vector2 currentInfluence = barInfluence.anchorMax;
        Vector2 currentMoney = barMoney.anchorMax;

        // Animate Texts and Images
        while (elapsed < duration)
        {
            // Forward time
            elapsed += Time.deltaTime;
            // Convert the elapsed time into a percentage
            float normalizedTime = Mathf.Clamp01(elapsed / duration);
            // Randomize letters until the end of the coroutine where it locks in the letters to its actual values
            // ASCII Values that have a readable symbol (does not include space [32])
            // Note: This uses the int version of Random.Range which is inclusive, exclusive
            textMilitary.text = ((char)Random.Range(33,127)).ToString();
            textInfluence.text = ((char)Random.Range(33,127)).ToString();
            textMoney.text = ((char)Random.Range(33,127)).ToString();

            // Animate Images
            // Slowly slide the image bar upwards until it reaches its max height
            // Interpolate 
            currentMilitary.y = Mathf.Lerp(0f, targetMilitary, normalizedTime);
            currentInfluence.y = Mathf.Lerp(0f, targetInfluence, normalizedTime);
            currentMoney.y = Mathf.Lerp(0f, targetMoney, normalizedTime);
            // Set new values
            barMilitary.anchorMax = currentMilitary;
            barInfluence.anchorMax = currentInfluence;
            barMoney.anchorMax = currentMoney;

            // Wait for the next frame
            yield return null;
        }

        // Set final values
        // Images
        currentMilitary.y = targetMilitary;
        currentInfluence.y = targetInfluence;
        currentMoney.y = targetMoney;
        barMilitary.anchorMax = currentMilitary;
        barInfluence.anchorMax = currentInfluence;
        barMoney.anchorMax = currentMoney;
        // Texts
        textMilitary.text = $"#{militaryValue}";
        textInfluence.text = $"#{influenceValue}";
        textMoney.text = $"#{moneyValue}";
    }

}
