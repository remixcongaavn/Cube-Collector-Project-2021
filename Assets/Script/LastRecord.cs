using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class LastRecord : MonoBehaviour
{

    public Text displayScore;
    public Text displayLive;
    void Start()
    {

        displayScore.text = "Score: " + ScoreSystem.theScore.ToString();

        displayLive.text = "Live: " + ScoreSystem.CurrnetLive;
    }
}