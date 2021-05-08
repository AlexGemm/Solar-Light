using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserScript : MonoBehaviour{

    //Store the explosion prefab to create on a hit
    public GameObject explosion;



    //Float variable that stores the speed the lasers will go
    public float laserSpeed = 10.0f;



    //Every frame
    void Update(){

        //Move the laser down at a constant speed
        transform.Translate(Vector3.up * Time.deltaTime * laserSpeed);

    }

    //Make an explosion particle effect by taking the prefab with the explosion animation and instaniating it
    private void OnTriggerEnter(Collider other){

        if (other.tag != "Barrier" && other.tag != "Laser"){

            Instantiate(explosion, transform.position, transform.rotation);

        }

    }


}
