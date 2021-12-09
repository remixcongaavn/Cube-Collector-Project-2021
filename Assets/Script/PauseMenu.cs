using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        Debug.Log("Loading Menu..........");
        SceneManager.LoadScene("Menu");
    }

    public void GoToExit()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        Debug.Log("Exit game......... ");
        SceneManager.LoadScene("Exit");
    }

    public void saveGame()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        PlayerPrefs.SetInt("score", ScoreSystem.theScore);
        PlayerPrefs.SetString("name", NameTransfer.theName);
        PlayerPrefs.SetInt("Lives", ScoreSystem.CurrnetLive);
        Debug.Log("Saved game.........Name: " + NameTransfer.theName + " Score: " + ScoreSystem.theScore + "Lives: " + ScoreSystem.CurrnetLive);
    }

    public void loadGame()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        ScoreSystem.theScore = PlayerPrefs.GetInt("score");
        NameTransfer.theName = PlayerPrefs.GetString("name");
        ScoreSystem.CurrnetLive = PlayerPrefs.GetInt("Lives");
        SceneManager.LoadScene("Game");
        Resume();
        Debug.Log("Loading save game.......Name: " + NameTransfer.theName + " Score: " + ScoreSystem.theScore + "Lives: " + ScoreSystem.CurrnetLive);
    }
}