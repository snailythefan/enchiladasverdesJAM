using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we're using this ones too:
using UnityEngine.UI;
using TMPro;

public class P1KeySigns : MonoBehaviour
{
    //create the text to display
    [SerializeField] TextMeshProUGUI keyToPress;

    //this is the number of points we'll get with each good press
    public int Points = 1;


    //create a list using a range
    static string[] keys = {"W","A","S","D"};
    private KeyCode[] desiredKeys = {KeyCode.W,KeyCode.A,KeyCode.S,KeyCode.D};

    public List<string> keysRange = new List<string>(keys);


    void randomizedKey()
    {
        //this gives us a randomized string from our keysRange list
        string currentKey = keysRange[Random.Range(0,keysRange.Count - 1)];
        //then it displays it on the UI
        keyToPress.text = currentKey.ToString();

    }

    public bool keyPressed()
    {
        foreach (KeyCode keyToCheck in desiredKeys)
        {
            if(Input.GetKeyDown (keyToCheck) == keyToPress)
            P1Score.scoreValueP1 += Points;
            print ("PointUp");
            return true;
        }
            print ("Missed");
            return false;
    }


    void Start()
    {
        randomizedKey();
        keyPressed();
    }

    void Update()
    {
        //if we put keyPressed() here, we'll be able to get one point up, each time we press W
        //and only W
        //why? who knows


        //delete the "//" line to activate it and see what it does:
        //keyPressed();
    }
    


    

            

}
