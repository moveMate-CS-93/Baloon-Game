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

    void Start()
    {
        // Store the default camera size on Start
        if (mainCamera != null)
        {
            defaultCameraSize = mainCamera.orthographicSize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        if (players == null || players.Length == 0)
        {
            GameOverAction();
        }
    }


    public void Restart()
    {
<<<<<<< HEAD
        Debug.Log("Restart Button Clicked");

        // Hide the game over panel
        gameOverPanel.SetActive(false);
    
=======
>>>>>>> parent of 57dcc73 (did the timer but now game over is not getting hidden)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Reset camera size after restarting the scene
        if (mainCamera != null)
        {
            mainCamera.orthographicSize = defaultCameraSize;
        }
    }

    // Show game over panel and perform other actions
    private void GameOverAction()
    {
        gameOverPanel.SetActive(true);
    }
}
