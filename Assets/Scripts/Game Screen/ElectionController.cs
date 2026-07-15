// FRONT END

using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine.Audio;
// Game Screen :: CanvasGameScreen/ElectionHolder
// Attach this to the GameObject that holds the objects that contain the game's election data

// TEMP TESTING //
[System.Serializable]
public struct Election
{
    public string spritePath;
    public int totalValue;
    public int overallValue;
    public int winnerIndex;
}
// TEMP TESTING //

public class ElectionController : MonoBehaviour
{
    // TEMP TESTING //
    [SerializeField]
    List<Election> tempElections = new List<Election>();
    // Called by a temporary button
    public void ElectionStarter()
    {ElectionStart();}
    // TEMP TESTING //

    // Serialize Candidate Prefab
    [SerializeField] private GameObject candidatePrefab;
    // Declare the Canvas Group component, the Audio Source component, and the object List for each candidate
    private CanvasGroup canvasGroup;
    private AudioSource audioSource;
    private List<Election> candidateList;
    // Initialize a boolean tracker
    // It tracks whether the coroutines have finished and called the final election function call
    private bool electionFinal = false;

    // Assign the Canvas Group and Audio Source components when the object loads
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();      // Game Screen :: CanvasGameScreen/ElectionHolder
        audioSource = GetComponent<AudioSource>();      // Game Screen :: CanvasGameScreen/ElectionHolder

        // TEMP TESTING //
        candidateList = tempElections;
        // TEMP TESTING //
    }

    // Sets up OnSomethingChange event listener for the Election in the scene
    void OnEnable()
    {// OnSomethingChange += ElectionStart;
    }
    // Removes OnSomethingChange event listener for the Election in the scene
    void OnDisable()
    {// OnSomethingChange += ElectionStart;
    }

    // Creates the components for each candidate and animates them when it appears
    void ElectionStart()
    {
        // Clears all existing election UI elements before displaying new ones
        foreach (Transform child in transform.Find("MembersHolder"))
        {Destroy(child.gameObject);}
        // Hide the image result
        transform.Find("ImageResult").GetComponent<CanvasGroup>().alpha = 0;
        // Reset the boolean tracker
        electionFinal = false;

        // Create a list container for the coroutines
        List<IEnumerator> coroutineList = new List<IEnumerator>();

        // Get the overall max value in the list
        var maxTotal = candidateList.Max(obj => obj.totalValue);

        // Create a Candidate UI for each one in the candidates list
        foreach (var candidate in candidateList)
        {
            // Instantiate new Candidate
            GameObject newCandidate = Instantiate(candidatePrefab, transform.Find("MembersHolder"));
            // Change the candidate's character sprite
            newCandidate.transform.Find("ImageCandidate").GetComponent<Image>().sprite = Resources.Load<Sprite>($"{candidate.spritePath}");
            // Initialize the coroutine and save them
            coroutineList.Add(ElectionAnimate(newCandidate, candidate.totalValue, maxTotal, maxTotal.ToString().Length));
        }

        // Reveal the election pop up
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;

        // Play the tally_vote audio
        audioSource.Play();

        // Start coroutine animation of the elements
        foreach (var coroutine in coroutineList)
        {StartCoroutine(coroutine);}
    }

    // Plays an audio and sets an image based on the results
    // The results are determined whether the player won or lost the election
    // Called by ElectionAnimate()
    void ElectionEnd()
    {
        // Set audio based on the election results
        AudioResource audioResource = (candidateList[0].winnerIndex == 0) ? Resources.Load<AudioResource>("Sounds/SFX/win_election") : Resources.Load<AudioResource>("Sounds/SFX/lose_election");
        AudioSource resultAudio = transform.Find("TitleHolder").GetComponent<AudioSource>();
        resultAudio.resource = audioResource;
        // Set the sprite based on the election results
        Sprite spriteResult = (candidateList[0].winnerIndex == 0) ? Resources.Load<Sprite>("Sprites/Election/win_election") : Resources.Load<Sprite>("Sprites/Election/lose_election");
        Image resultImage = transform.Find("ImageResult").GetComponent<Image>();

        // Play the audio
        resultAudio.Play();
        // Set the image
        resultImage.sprite = spriteResult;
        transform.Find("ImageResult").GetComponent<CanvasGroup>().alpha = 1;
    }

    // Creates a random string of characters based on an integer length parameter
    // Called by ElectionAnimate()
    string GenerateLetters(int length)
    {
        // Initialize an empty character list with the same length as the parameter
        char[] textValue = new char[length];
        // Randomize each character
        // Only includes ASCII values that have a readable symbol (does not include space [32])
        // Note: This uses the int version of Random.Range which is inclusive, exclusive
        // (char) translates the integer into an ASCII character
        for (int i = 0; i < length; i++)
        {textValue[i] = (char)Random.Range(33,127);}

        // Returns the character list, converted into a string
        return new string(textValue);
    }

    // Animate the image bar and the text values
    // Calls GenerateLetters() and ElectionEnd()
    IEnumerator ElectionAnimate(GameObject candidateInterface, int totalValue, int totalMax, int maxLength)
    {
        // Animation variables
        float duration = 5f;    // Animates for a duration of 5 seconds
        float elapsed = 0f;     // Starts at 0 seconds

        // Find Text and Image Object
        TMP_Text textTotal = candidateInterface.transform.Find("ResourcesHolder/TextBoundaryBox/TextVoters").GetComponent<TMP_Text>();
        RectTransform barTotal = candidateInterface.transform.Find("ResourcesHolder/ImageBoundaryBox/ImageVoters").GetComponent<RectTransform>();

        // Calculate target anchor heights
        // The (float) is used to convert the values to float first
        // Note: integer division results to integer results
        float targetTotal = (float)totalValue / totalMax;
        // Store initial anchor values
        Vector2 currentTotalAnchors = barTotal.anchorMax;

        // Animate Texts and Images
        // While the elapsed time is still less than the intended duration time
        while (elapsed < duration)
        {
            // Forward the elapsed time
            elapsed += Time.deltaTime;
            // Convert the elapsed time into a percentage
            float normalizedTime = Mathf.Clamp01(elapsed / duration);

            // Animate Texts
            // Randomize each character of the values
            // Calls GenerateLetters()
            textTotal.text = $"{GenerateLetters(maxLength)}\nvoters";

            // Animate Images
            // Slowly slide the image bar upwards until it reaches its max height
            // Interpolate
            currentTotalAnchors.y = Mathf.Lerp(0f, targetTotal, normalizedTime);
            // Set the calculated new values
            barTotal.anchorMax = currentTotalAnchors;

            // Wait for the next frame
            yield return null;
        }

        // Set final values after finishing the animation
        // Images
        currentTotalAnchors.y = targetTotal;
        barTotal.anchorMax = currentTotalAnchors;
        // Texts
        textTotal.text = $"{totalValue}\nvoters";

        // Stop the tally_vote audio
        audioSource.Stop();

        // Run ElectionEnd() only if it has not been called yet
        if (!electionFinal)
        {
            electionFinal = true;
            ElectionEnd();
        }
    }

}
