using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//these are things we need to use in this script
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{

    //Here we stablish that the timer ends when it hits 0
    float currentTime = 0f;
    //starting time in the countdown
    public float startingTime = 10f;

    [SerializeField] TextMeshProUGUI countdownText;
    
    void Start()
    {
        currentTime = startingTime;    
    }

    
    void Update()
    {
        //this is how we're making the timer count down
        currentTime -= 1 * Time.deltaTime;
        //we override the textUI with our own coutdown:
        countdownText.text = currentTime.ToString("0.0");

        //what to do when the timer reaches 0
        if (currentTime <= 0)
        {
            //the timer stays at 0
            currentTime = 0;
            //and then it loads the next scene
            SceneManager.LoadScene("Scene3");
            Debug.Log("Round ended!");
        }


    }
}
