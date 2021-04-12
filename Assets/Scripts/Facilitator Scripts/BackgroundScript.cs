using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour{

    //Game object reference to the Star prefab
    public GameObject star;



    //Float variable that stores where on the x axis a star could appear
    private float starXRange = 9.0f;



    //Initialization
    void Start(){

        //Start spawning stars every 0.05 seconds
        InvokeRepeating("CreateStar", 0f, 0.05f);

    }

    //Create a star at a random X position
    void CreateStar(){

        //Vector3 that decides where a star will spawn, the only axis that needs to be established is where it will be on the x axis
        Vector3 starPosition = new Vector3(Random.Range(-starXRange, starXRange), star.transform.position.y, star.transform.position.z);

        //Create the star using the starPosition vector
        Instantiate(star, starPosition, star.transform.rotation);

    }

}
