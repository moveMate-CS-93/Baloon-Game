using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private bool isGameOver = false;

    // Feedback UI elements
    [SerializeField] private Text startoffFeedback;
    [SerializeField] private Text score5Feedback;
    [SerializeField] private Text score10Feedback;
    [SerializeField] private Text score20Feedback;
    [SerializeField] private Text score30Feedback;
    [SerializeField] private Text score40Feedback;
    [SerializeField] private Text score50Feedback;

    // Start is called before the first frame update
    void Start()
    {
        // Start scoring when the game begins
        StartScoring();

        startoffFeedback.gameObject.SetActive(true);
        score5Feedback.gameObject.SetActive(false);
        score10Feedback.gameObject.SetActive(false);
        score20Feedback.gameObject.SetActive(false);
        score30Feedback.gameObject.SetActive(false);
        score40Feedback.gameObject.SetActive(false);
        score50Feedback.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();

            // Check for score milestones and display feedback
            CheckScoreMilestones();
        }
    }

    // Call this method when the game is over
    public void GameOver()
    {
        isGameOver = true;
        // Implement any additional actions when the game is over
        // For example, you can show a game over panel or perform other actions.
    }

    // Start scoring
    public void StartScoring()
    {
        // Reset score when scoring starts
        score = 0f;
        isGameOver = false;
    }

    // Check for score milestones and display feedback
    private void CheckScoreMilestones()
    {
        int intScore = (int)score;

        if (intScore == 0)
        {
            StartCoroutine(DisplayStartoffFeedback());
        }
        else if (intScore == 5)
        {
            StartCoroutine(DisplayScore5Feedback());
        }
        else if (intScore == 10)
        {
            StartCoroutine(DisplayScore10Feedback());
        }
        else if (intScore == 20)
        {
            StartCoroutine(DisplayScore20Feedback());
        }
        else if (intScore == 30)
        {
            StartCoroutine(DisplayScore30Feedback());
        }
        else if (intScore == 40)
        {
            StartCoroutine(DisplayScore40Feedback());
        }
        else if (intScore == 50)
        {
            StartCoroutine(DisplayScore50Feedback());
        }
    }

    // Feedback coroutine methods

    private IEnumerator DisplayStartoffFeedback()
    {
        startoffFeedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        startoffFeedback.gameObject.SetActive(false);
    }

    private IEnumerator DisplayScore5Feedback()
    {
        score5Feedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        score5Feedback.gameObject.SetActive(false);
    }

    private IEnumerator DisplayScore10Feedback()
    {
        score10Feedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        score10Feedback.gameObject.SetActive(false);
    }

    private IEnumerator DisplayScore20Feedback()
    {
        score20Feedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        score20Feedback.gameObject.SetActive(false);
    }

    private IEnumerator DisplayScore30Feedback()
    {
        score30Feedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        score30Feedback.gameObject.SetActive(false);
    }

    private IEnumerator DisplayScore40Feedback()
    {
        score40Feedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        score40Feedback.gameObject.SetActive(false);
    }

    private IEnumerator DisplayScore50Feedback()
    {
        score50Feedback.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        score50Feedback.gameObject.SetActive(false);
    }

}
