using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour{
    
    //Stores the objects speed at which it falls down
    private float fallSpeed = 5.0f;

    //Stores the objects speed at which it rotates
    private float rotateSpeed = 200.0f;



    //Every frame
    void Update(){

        //Move the asteroid down at a constant speed, it should be in the world space' y since it's rotating
        transform.Translate(Vector3.down * Time.deltaTime * fallSpeed, Space.World);
        //Rotate the asteroid on the z axis
        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * rotateSpeed);

    }

}
