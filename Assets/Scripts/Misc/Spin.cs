using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour{

    //Boolean variabel that is used to check if the object has gone as high as it should before moving back down
    private bool movedUp = false;

    //Every frame
    void Update(){

        //Spin the ISS
        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * 1.5f);

    }

}
