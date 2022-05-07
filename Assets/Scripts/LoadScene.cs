using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Don't forget Scene Management to load scenes!
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{
    //On click, it'll play this sound:
    public AudioSource Playclick;

    //the time we wait before loading the next scene:
    public float transTime = 1f;

    //the thing that controls our animated transition:
    //public Animator transition;


    //the function that will be triggered when we click the button:
    public void LoadTheScene()
    {
        //play this sound:
        Playclick.Play();

        //start our coroutine before we transition
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        //This will send us to the next scene in the SceneManager

    }

    //this is our coroutine
    IEnumerator LoadLevel (int levelIndex)
    {
        //this will play out animation
        //transition.SetTrigger("Start");
        //this activates our animation trigger called "Start"

        //the time we wait
        yield return new WaitForSeconds(transTime);

        //and finally loadScene
        SceneManager.LoadScene(levelIndex);
        Debug.Log("GameStart");
    }



}
