using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserScript : MonoBehaviour{

    //Float variable that stores the speed the lasers will go
    public float laserSpeed = 10.0f;

    //Used if the enemy makes the laser diverge left or right
    public float laserDivGiven = 0.0f;
    private float laserDiv = 0.0f;

    //Initialization
    void Start(){

        //Make the div speed individual for each laser
        laserDiv = laserDivGiven;

    }

    //Every frame
    void Update(){

        //Move the laser down at a constant speed
        transform.Translate(Vector3.down * Time.deltaTime * laserSpeed);

        //Move the laser left or right as needed
        transform.Translate(Vector3.right * Time.deltaTime * laserDiv);

    }

}
