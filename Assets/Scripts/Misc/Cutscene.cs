using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Cutscene : MonoBehaviour{

    private GameObject theCamera;
    public TextMeshProUGUI title;
    public GameObject skipCutsceneString;


    private string titleTextFull = "Solar Light";
    private string textOnScreen = "";


    //Initialization
    void Start(){

        StartCoroutine(ScenePlayer());

        theCamera = GameObject.Find("Main Camera");

    }

    //Every frame
    void Update(){

        theCamera.transform.Translate(Vector3.up * Time.deltaTime * 0.1f, Space.World);

        //If the user presses any key tell them how to skip
        if (Input.anyKey){

            skipCutsceneString.SetActive(true);

        }

        //Skip the cutscene at any time if the user wants to (when they press the s key)
        if(Input.GetKeyDown(KeyCode.S)){

            SceneManager.LoadScene("Earth");

        }

    }

    // Start displaying the Canvas elements, Then after a set time load the scene
    private IEnumerator ScenePlayer(){

        StartCoroutine(ShowTitle());

        yield return new WaitForSeconds(8.0f);

        SceneManager.LoadScene("Earth");


    }

    //Display the text over time using a for loop for as long as the text of the title is
    IEnumerator ShowTitle(){

        for(int i = 0; i <=  titleTextFull.Length; i++){

            textOnScreen = titleTextFull.Substring(0, i);

            //After adding a character to the string, display it to the text in game
            title.text = textOnScreen;

            yield return new WaitForSeconds(0.5f);

        }

    }

}
