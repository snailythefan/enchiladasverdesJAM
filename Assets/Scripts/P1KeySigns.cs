using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//we're using this ones too:
using UnityEngine.UI;
using TMPro;

public class P1KeySigns : MonoBehaviour
{
    //create the text to display
    [SerializeField] TextMeshProUGUI txt;


    //create a list using a range
    static string[] keys = {"W","A","S","D"};
    public List<string> keysRange = new List<string>(keys);


    void randomizedKey()
    {
        string currentKey = keysRange[Random.Range(0,keysRange.Count - 1)];
        //txt = gameObject.GetComponent<Text>();
        //txt.text = keys.ToString();
        txt.text = currentKey.ToString();
    }

    void GameLoop()
    {
        
    }
    void Start()
    {
        
    }
    


    

            

}
