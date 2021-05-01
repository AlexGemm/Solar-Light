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

            //Start the Earth Scene
            SceneManager.LoadScene("Earth");

        }
            

    }

    public void LoadMoon(){

        //If the user has yet to pass the Earth stage
        if (ValueStorage.stagePoint == 20){

            //Start the Earth Scene
            SceneManager.LoadScene("Moon");

        }


    }

    //Start the Earth Level
    public void LoadLevelSelect(){

        //Start the Earth Scene
        SceneManager.LoadScene("Select");

    }

}
