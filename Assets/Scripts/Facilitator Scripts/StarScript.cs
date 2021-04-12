using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour{

    //Float variable that stores the speed stars will go
    private float starSpeed = 15.0f;



    //Every frame
    void Update(){

        //Move the star down at a constant speed
        transform.Translate(Vector3.down * Time.deltaTime * starSpeed);

    }

}
