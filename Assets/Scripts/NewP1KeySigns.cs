using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we're using this ones too:
using UnityEngine.UI;
using TMPro;

public class NewP1KeySigns : MonoBehaviour
{
    //create the text to display
    [SerializeField] TextMeshProUGUI keyToPress;

    //this is the number of points we'll get with each good press
    public int Points = 1;


    //create a list using a range
    static string[] keys = {"W","A","S","D"};
    private KeyCode[] desiredKeys = {KeyCode.W,KeyCode.A,KeyCode.S,KeyCode.D};

    public List<string> keysRange = new List<string>(keys);

    //ant animation
    public GameObject Ant1; 

    public void randomizedKey()
    {
        //this gives us a randomized string from our keysRange list
        string currentKey = keysRange[Random.Range(0,keysRange.Count - 1)];
        //then it displays it on the UI
        keyToPress.text = currentKey.ToString();

    }

    void Start()
    {
        randomizedKey();
        //trying to transform the first ant position
        //Ant1.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        Ant1.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.AngleAxis(180, Vector3.up), Time.deltaTime * (.2f));
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            //here we're checking specifically for the WASD keys
            foreach (KeyCode key in desiredKeys)
            {    
                if (Input.GetKey(key))
                {
                    //this switch compares the key to the possible options
                    switch (key)
                    {
                    //not the best solution but it works. individual ifs
                    case KeyCode.W:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "W")
                        {
                            Debug.Log("correct!");
                            P1Score.scoreValueP1 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    case KeyCode.A:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "A")
                        {
                            Debug.Log("correct!");
                            P1Score.scoreValueP1 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    case KeyCode.S:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "S")
                        {
                            Debug.Log("correct!");
                            P1Score.scoreValueP1 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    case KeyCode.D:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "D")
                        {
                            Debug.Log("correct!");
                            P1Score.scoreValueP1 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    default:
                        Debug.Log("Missed");
                        break;
                    }
                }
            }
        }
    }
}