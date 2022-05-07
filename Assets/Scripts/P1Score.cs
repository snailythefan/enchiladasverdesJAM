using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we need these
using UnityEngine.UI;
using TMPro;

public class P1Score : MonoBehaviour
{
    //declare our initial score value
    //its static so it can be accessed from anywhere
    public static int scoreValueP1 = 0;

    //connection to our text component
    [SerializeField] TextMeshProUGUI CurrentP1Score;

    void Start()
    {
        CurrentP1Score = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        CurrentP1Score.text = "Points: " + scoreValueP1;
    }

}
