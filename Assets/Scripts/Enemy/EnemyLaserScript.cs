using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserScript : MonoBehaviour{

    //Float variable that stores the speed the lasers will go
    public float laserSpeed = 10.0f;



    //Every frame
    void Update(){

        //Move the laser down at a constant speed
        transform.Translate(Vector3.down * Time.deltaTime * laserSpeed);

    }

}
