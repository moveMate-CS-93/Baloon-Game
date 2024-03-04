using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private float score;

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
    }
<<<<<<< HEAD

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
=======
>>>>>>> parent of a5e1c6e (all done, game is working perfectly)
}
