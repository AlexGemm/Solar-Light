using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour{

    //Store button objects
    public GameObject moon;
    public GameObject greyMoon;


    //Initialization
    void Start(){

        //If you are in the level select screen
        if (SceneManager.GetActiveScene().name == "Select") {

            //When loading if the stage is at part 19 make the moon active
            if (ValueStorage.stagePoint > 19){

                greyMoon.SetActive(false);
                moon.SetActive(true);

            }

        }

    }

    //Start the Earth Level
    public void LoadEarth(){

        //If the user has yet to pass the Earth stage
        if(ValueStorage.stagePoint == 0){

            StartCoroutine(startScene("Cutscene"));

        }
            

    }

    //Start the moon level
    public void LoadMoon(){

        //If the user has yet to pass the Moon stage
        if (ValueStorage.stagePoint == 20){

            StartCoroutine(startScene("Moon"));

        }


    }

    //Start the level select screen
    public void LoadLevelSelect(){

        if (SceneManager.GetActiveScene().name == "Instructions"){

            StartCoroutine(startScene("Select"));

        }
        else{

            SceneManager.LoadScene("Select");

        }

    }

    //Start the Instructions Screen
    public void LoadInstructions(){

        if(SceneManager.GetActiveScene().name == "Select"){

            StartCoroutine(startScene("Instructions"));

        }
        else{

            SceneManager.LoadScene("Instructions");

        }

    }

    //Play the audio for button press but wait for it to finish before loading the scene
    private IEnumerator startScene(string sceneName){

        AudioSource sound = GameObject.Find("Sound").GetComponent<AudioSource>();

        sound.Play();

        yield return new WaitForSeconds(sound.clip.length);

        SceneManager.LoadScene(sceneName);

    }

}
