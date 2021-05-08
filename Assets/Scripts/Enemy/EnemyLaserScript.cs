using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserScript : MonoBehaviour{

    //Store the explosion prefab to create on a hit
    public GameObject explosion;



    //Float variable stores speed that the enemy laser will move down
    public float laserSpeed = 10.0f;

    //Float variables given by the enemy and made individual for each instance, moves the laser left or right
    public float laserDivGiven = 0.0f;
    private float laserDiv = 0.0f;



    //Initialization
    void Start(){

        //Make the div speed individual for each laser
        laserDiv = laserDivGiven;

    }

    //Every frame
    void Update(){

        //Move the laser down
        transform.Translate(Vector3.down * Time.deltaTime * laserSpeed);

        //Move the laser right, laserDiv can be negative thus moving the laser left
        transform.Translate(Vector3.right * Time.deltaTime * laserDiv);

    }

    //Make an explosion particle effect by taking the prefab with the explosion animation and instaniating it
    private void OnTriggerEnter(Collider other){

        if (other.tag != "Barrier" && other.tag != "Laser"){

            Instantiate(explosion, transform.position, transform.rotation);

        }

    }

}
