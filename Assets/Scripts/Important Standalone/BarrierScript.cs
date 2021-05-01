using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour{

    //When another object collides with the barrier
    private void OnTriggerEnter(Collider other){

        //Destroy the other object
        Destroy(other.gameObject);

    }

}
