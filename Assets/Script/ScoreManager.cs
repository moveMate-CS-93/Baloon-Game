using System.Collections;
using System.Collections.Generic;
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
        // Implement any additional actions when the game is over
        // For example, you can show a game over panel or perform other actions.
    }
}
