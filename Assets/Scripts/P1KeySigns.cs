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

    void keyPressed()
    {
        //if()
    }

    void pointsUp()
    {

    }




    void Start()
    {
        randomizedKey();
    }

    void Update()
    {
        //bool hasLetterbeenPressed()
        //{
          //  foreach (KeyCode keyToCheck);
        //}
    }
    


    

            

}
