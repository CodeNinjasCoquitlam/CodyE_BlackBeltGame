using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }

        if (isPaused && Input.GetKeyDown(KeyCode.M))
        {
            QuitGame();
        }




    }

    public void TogglePause()
    {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1 ;

    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }


    public void QuitGame()
    {
        // Add logic to quit or go to main menu
        Debug.Log("Quitting game...");
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Title Screen");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }




}
