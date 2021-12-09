using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectScore : MonoBehaviour
{
    public AudioSource collectSound;
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Debug.Log("Add Points");
        ScoreSystem.theScore += 10;
        Destroy(gameObject);

        if (ScoreSystem.theScore == 80)
        {
            SceneManager.LoadScene("Exit");
        }
    }
}
