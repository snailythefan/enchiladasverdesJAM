using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we'll need these
using UnityEngine.UI;
using TMPro;

public class FinalScore : MonoBehaviour
{
    //taking the data that will determine the points,
    //taken from another script
    private static int P1finalScore = P1Score.scoreValueP1;
    private static int P2finalScore = P2Score.scoreValueP2;
    //our final score
    private static int TruefinalScore;

    //This is the UI that will show our Score
    //[SerializeField] TextMeshProUGUI endScore;

    //these are the endings we'll set active
    public GameObject Player1Wins;
    public GameObject Player2Wins;
    public GameObject TieWins;

    void Start()
    {

        //we need this code to unlock the cursor again
         Cursor.lockState = CursorLockMode.None;

         
        //We do this so the Score resets to 0, and then it grabs the new
        //scoreValue made after we played again
        P1finalScore = 0;
        P1finalScore = P1Score.scoreValueP1;

        P2finalScore = 0;
        P2finalScore = P2Score.scoreValueP2;


        //this connect our end score to our UI
       //endScore = GetComponent<TextMeshProUGUI>();

       //this will run our if loop
       determineWinner();

       //finally this will show the total score on the UI
       //endScore.text = "Total Points: " + TruefinalScore;
    }

    void determineWinner()
    {
        if(P1finalScore > P2finalScore)
        {
            Player1Wins.SetActive(true);
            P1finalScore = TruefinalScore;
        }
        else if(P1finalScore < P2finalScore)
        {
            Player2Wins.SetActive(true);
            P2finalScore = TruefinalScore;
        }
        else if(P1finalScore == P2finalScore)
        {
            TieWins.SetActive(true);
            P1finalScore = TruefinalScore;
        }
        

    }


}
