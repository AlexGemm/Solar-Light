using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour{

    //Float variable that stores the speed stars will go
    public float asteroidSpeed = 2.0f;
    //Float variable that stores the rotation speed (purely for visual effect)
    public float rotateSpeed = 15.0f;



    //Every frame
    void Update(){

        //Move the asteroid down at a constant speed, it should be in the world space' y since it's rotating
        transform.Translate(Vector3.down * Time.deltaTime * asteroidSpeed, Space.World);
        //Rotate the asteroid on the z axis
        transform.Rotate(new Vector3(0.0f, 0.0f, 1.0f) * Time.deltaTime * rotateSpeed);

    }

    private void OnTriggerEnter(Collider other){

        if(other.tag != "Barrier"){

            if (other.tag == "Player"){

                Destroy(gameObject);

            }
            else{

                Destroy(other.gameObject);
                Destroy(gameObject);

            }

        }

    }

}
