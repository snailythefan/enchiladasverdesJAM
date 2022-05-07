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
    float startingTime = 105f;

    [SerializeField] TextMeshProUGUI countdownText;
    
    void Start()
    {
        currentTime = startingTime;    
    }

    
    void Update()
    {
        //this is how we're making the timer count down
        currentTime -= 1 * Time.deltaTime;
        print(currentTime);
    }
}
