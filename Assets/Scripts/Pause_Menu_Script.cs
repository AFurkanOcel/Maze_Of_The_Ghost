using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu_Script : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    private bool escapePressed = false;

    void Update()
    {
        // Detect Escape key press using Input.GetAxis
        if (Input.GetAxis("Escape") > 0 && !escapePressed)
        {
            escapePressed = true; // Mark Escape as pressed
            TogglePause();        // Toggle pause menu
        }
        else if (Input.GetAxis("Escape") == 0)
        {
            escapePressed = false; // Reset the flag when Escape is released
        }
    }

    void TogglePause()
    {
        GameIsPaused = !GameIsPaused;

        if (GameIsPaused)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Hide the pause menu
        Time.timeScale = 1f; // Resume the game
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true); // Show the pause menu
        Time.timeScale = 0.01f; // Pause the game
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; // Resume the game
        GameIsPaused = false;
        SceneManager.LoadScene(0);
    }
}
