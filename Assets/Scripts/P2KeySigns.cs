using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we're using this ones too:
using UnityEngine.UI;
using TMPro;

public class P2KeySigns : MonoBehaviour
{
    //create the text to display
    [SerializeField] TextMeshProUGUI keyToPress;

    //this is the number of points we'll get with each good press
    public int Points = 1;


    //create a list using a range
    static string[] keys = {"I","J","K","L"};
    private KeyCode[] desiredKeys = {KeyCode.I,KeyCode.J,KeyCode.K,KeyCode.L};

    public List<string> keysRange = new List<string>(keys);

    //ant animation
    public GameObject Ant1; 

    public void randomizedKey()
    {
        //this gives us a randomized string from our keysRange list
        string currentKey = keysRange[Random.Range(0,keysRange.Count)];
        //then it displays it on the UI
        keyToPress.text = currentKey.ToString();

    }

    void Start()
    {
        P2Score.scoreValueP2 = 0;
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
                    case KeyCode.I:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "I")
                        {
                            Debug.Log("correct!");
                            P2Score.scoreValueP2 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    case KeyCode.J:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "J")
                        {
                            Debug.Log("correct!");
                            P2Score.scoreValueP2 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    case KeyCode.K:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "K")
                        {
                            Debug.Log("correct!");
                            P2Score.scoreValueP2 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            Debug.Log("incorrect");
                        }
                        break;
                    case KeyCode.L:
                        Debug.Log("Pressed" + key);
                        if(keyToPress.text == "L")
                        {
                            Debug.Log("correct!");
                            P2Score.scoreValueP2 += Points;
                            randomizedKey();
                        }
                        else
                        {
                            //let's test if this gives us a new letter after we missed
                            //randomizedKey();
                            Debug.Log("incorrect");
                        }
                        break;
                    default:
                        //let's test if this gives us a new letter after we missed
                        //randomizedKey();
                        Debug.Log("Missed");
                        break;
                    }
                }
            }
        }
    }
}