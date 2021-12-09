using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveName : MonoBehaviour
{
    public Text displayName;

    public void Start()
    {
        displayName.text = "Name: " + NameTransfer.theName;
    }
}