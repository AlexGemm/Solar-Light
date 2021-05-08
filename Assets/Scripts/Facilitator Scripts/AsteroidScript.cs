using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour{

    //Store the explosion prefab to create on a hit
    public GameObject explosion;



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

        //If the object it's colliding with is not the barrier
        if(other.tag != "Barrier"){

            //If the object it's colliding with is the player
            if (other.tag == "Player"){

                Instantiate(explosion, transform.position, transform.rotation);

                //Only destroy the asteroid, the rest will be taken care of in the player controller
                Destroy(gameObject);

            }
            //Else if it is a powerup
            else if (other.tag == "Powerup"){

                //Ignore it

            }
            //Otherwise simply destroy the object and itself
            else{

                //Play the sound of hits
                GameObject.Find("Facilitator").GetComponent<AudioSource>().Play();

                Destroy(other.gameObject);
                Destroy(gameObject);

            }

        }

    }

}
