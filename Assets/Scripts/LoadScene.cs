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

    //the 2 items for the credits screen
    public GameObject credits;
    public GameObject closeButton;

    //the instructions screen
    public GameObject Instructions;
    public GameObject StartButton;

    //we need to turn off the play button for the credits scene
    public GameObject PlayButtonHide;


    //the function that will be triggered when we click the button:
    public void LoadTheScene()
    {
        //play this sound:
        Playclick.Play();

        //start our coroutine before we transition
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        //This will send us to the next scene in the SceneManager

    }

    //this is the click that turns on the instructions
    public void Instruct()
    {
        Playclick.Play();
        Instructions.SetActive (true);
        StartButton.SetActive (true);
    }

    //this is the click that turns on the credits
    public void creditsScreen()
    {
        Playclick.Play();
        credits.SetActive (true);
        closeButton.SetActive (true);
        PlayButtonHide.SetActive(false);
    }

    //this is what closes the credits
    public void BacktoMM()
    {
        Playclick.Play();
        credits.SetActive(false);
        closeButton.SetActive(false);
        PlayButtonHide.SetActive(true);

    }

    //this is our coroutine
    IEnumerator LoadLevel (int levelIndex)
    {
        //this part of the code WILL stop the player from clicking the button several times
        //bcus we are locking the cursor to the middle of the screen
        Cursor.lockState = CursorLockMode.Locked;
        //we will need to unlock it on the start of a Code for next scene.


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
