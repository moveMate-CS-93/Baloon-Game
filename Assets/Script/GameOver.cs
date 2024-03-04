using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
<<<<<<< HEAD
    public Camera mainCamera; // Reference to your main camera
    private TimerManager timerManager;
    private ScoreManager scoreManager;
    // Default camera size
    private float defaultCameraSize;

    void Start()
    {
        // Store the default camera size on Start
        if (mainCamera != null)
        {
            defaultCameraSize = mainCamera.orthographicSize;
        }
        // Find the TimerManager
        timerManager = FindObjectOfType<TimerManager>();

        // Find the ScoreManager
        scoreManager = FindObjectOfType<ScoreManager>();
    }
=======
>>>>>>> parent of a5e1c6e (all done, game is working perfectly)

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player") == null)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void Restart()
    {
        Debug.Log("Restart Button Clicked");

        // Hide the game over panel
        if (gameOverPanel != null)
        {
            Debug.Log("Hiding Game Over Panel");
            gameOverPanel.SetActive(false);

            // Set gameOverPanel to null
            gameOverPanel = null;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
<<<<<<< HEAD

        // Reset camera size after restarting the scene
        if (mainCamera != null)
        {
            mainCamera.orthographicSize = defaultCameraSize;
        }
        // Restart the timer
        if (timerManager != null)
        {
            timerManager.RestartTimer();
        }
        // Reset the score
        if (scoreManager != null)
        {
            scoreManager.ResetScore();
        }
    }

    // Show game over panel and perform other actions
    private void GameOverAction()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
=======
>>>>>>> parent of a5e1c6e (all done, game is working perfectly)
    }
}
