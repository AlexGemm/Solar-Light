using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueStorage : MonoBehaviour{

    //Tells the whole game what level it is (more accuratly checkpoint)
    public static int stagePoint = 0;

    //Dont destroy on load
    void Awake(){

        DontDestroyOnLoad(this);

    }

}
