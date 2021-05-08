using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour{

    //Destroy the animation game object once it is done
    void Start(){

        Destroy(gameObject, 0.14f);

    }

}
