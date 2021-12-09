using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    public static int CurrnetLive = 3;
    public Text liveText;

    void Start()
    {
        liveText.text = "Live left: " + CurrnetLive.ToString();
    }


    void Update ()
    {
        liveText.text = "Live left: " + CurrnetLive.ToString();
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
    }

    
}
