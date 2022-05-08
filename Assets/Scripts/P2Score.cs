using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we need these
using UnityEngine.UI;
using TMPro;

public class P2Score : MonoBehaviour
{
    //declare our initial score value
    //its static so it can be accessed from anywhere
    public static int scoreValueP2 = 0;

    //connection to our text component
    [SerializeField] TextMeshProUGUI CurrentP2Score;

    void Start()
    {
        CurrentP2Score = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        CurrentP2Score.text = "Points: " + scoreValueP2;
    }

}
