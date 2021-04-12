using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour{

    //Stores the prefab for the asteroid
    public GameObject asteroid;



    //Float variable that stores the seconds before another asteroid spawns
    public float spawnInterval = 2.0f;

    //Float variables that store the limits for the region an asteroid can spawn
    private float spawnBorderStart = 5.0f;
    private float spawnBorderEnd = 8.0f;



    //Initializations
    void Start(){

        StartCoroutine(SpawnAsteroids());

    }

    //Spawns Asteroids
    IEnumerator SpawnAsteroids(){

        while (true){

            //Switches which side the asteroid will spawn on after each method call by changing the the limits are positive or negative on the z axis
            spawnBorderEnd *= -1;
            spawnBorderStart *= -1;

            //Vector that stores where the asteroid will spawn
            Vector3 spawnPosition = new Vector3(Random.Range(spawnBorderStart, spawnBorderEnd), asteroid.transform.position.y, asteroid.transform.position.z);

            //Create an asteroid and set where is spawns according to the random position of the spawnPosition vector
            Instantiate(asteroid, spawnPosition, asteroid.transform.rotation);

            yield return new WaitForSeconds(spawnInterval);

        }

    }
}
