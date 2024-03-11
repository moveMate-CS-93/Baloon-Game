using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Camera mainCamera; // Reference to your main camera

    // Default camera size
    private float defaultCameraSize;

    private TimerManager timerManager; // Reference to the TimerManager script

    void Start()
    {
        // Store the default camera size on Start
        if (mainCamera != null)
        {
            defaultCameraSize = mainCamera.orthographicSize;
        }

        // Find and store the TimerManager instance
        timerManager = TimerManager.Instance;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            GameOverAction();
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

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
    }

    // Show game over panel and perform other actions
    private void GameOverAction()
    {
        gameOverPanel.SetActive(true);

        // Stop the timer when the game over panel appears
        if (timerManager != null)
        {
            timerManager.StopTimer();
        }
    }
}
