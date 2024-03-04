using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;
    private bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }

    // Call this method when the game is over
    public void GameOver()
    {
        isGameOver = true;

        // Stop the timer
        if (TimerManager.Instance != null)
        {
            TimerManager.Instance.StopTimer();
        }
    }

    // Call this method to reset the score
    public void ResetScore()
    {
        score = 0f;
        scoreText.text = "0";
        isGameOver = false;
    }
}
