using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
    public void goToMenu()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        Debug.Log("Loading Meu....!");
        SceneManager.LoadScene("Menu");
    }

    public void goToExit()
    {
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Click);
        Debug.Log("Loading Exit....!");
        SceneManager.LoadScene("Exit");
    }


    public void ExitGame()
    {
        Debug.Log("Quit");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}