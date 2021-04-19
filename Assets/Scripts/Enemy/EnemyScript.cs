using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour{

    //Stores the current type of laser the player is using
    public GameObject currentLaser;
    //Stores the audio clip for attacking
    public AudioClip attackSound;



    //Two floats, one is a number given by the facilitator, the other is individual to each enemy, both store enemy health
    public float enemySpeedGiven = 0.0f;
    private float enemySpeed = 0.0f;

    //Two ints, one is a number given by the facilitator, the other is individual to each enemy, both store enemy health
    public int enemyHealthGiven = 0;
    private int enemyHealth = 0;

    //Floats that manage where an enemy can go when moving, this is given by the facilitator and then stored
    public float enemySpaceStart = -0.0f;
    private float indSpaceStart = 0.0f;
    public float enemySpaceEnd = 0.0f;
    private float indSpaceEnd = 0.0f;

    //Float variable that decides how fast this enemy fires
    public float fireRateGiven = 0.0f;
    private float fireRate = 0.0f;


    //Initializations
    void Start(){

        //Give an individual enemy it's values
        enemySpeed = enemySpeedGiven;
        enemyHealth = enemyHealthGiven;
        indSpaceStart = enemySpaceStart;
        indSpaceEnd = enemySpaceEnd;
        fireRate = fireRateGiven;

        //Move into scene and start firing it's laser
        StartCoroutine(StartUp());

    }

    //Every frame
    void Update(){

        //Move the enemy
        MoveEnemy();

    }

    //Integer variable that stores how many times the enemy had been hit by a player laser
    private int timesHit = 0;

    //Upon collision
    private void OnTriggerEnter(Collider other){

        //If the object is not a power up
        if(other.CompareTag("Powerup") == false){

            //Increase the times hit variable
            timesHit++;

            //Destroy the laser
            Destroy(other.gameObject);

        }
        //If times hit is equal or greater to the enemy health
        if (timesHit >= enemyHealth){

            //Destroy the enemy
            Destroy(gameObject);

            //Decrease the enemies alive variable in the Game Manager
            GameObject.Find("Facilitator").GetComponent<GameManager>().enemiesAlive--;


        }

    }

    //Boolean variable that stores if the enemy has hit the right border it is supposed to go to
    private bool hitRightBorder = false;

    //Move the enemy
    void MoveEnemy(){

        //If the enemy has yet to hit the right border
        if (hitRightBorder == false){

            //Move it to the right
            transform.Translate(Vector3.right * Time.deltaTime * enemySpeed);

            //If it then hits the right border
            if (transform.position.x > indSpaceEnd){

                //Indicate that it has hit the right border
                hitRightBorder = true;

            }

        }
        //If the enemy has hit the right border
        if (hitRightBorder == true){

            //Move it left
            transform.Translate(Vector3.left * Time.deltaTime * enemySpeed);

            //If it has hit the left border
            if (transform.position.x < indSpaceStart){

                //Indicate that it hit the left border
                hitRightBorder = false;

            }

        }

    }

    //Intro section to move forward into scene
    private IEnumerator StartUp(){

        //While not at the enemy position
        while (transform.position.y >= 4.0f){

            //Move down
            transform.Translate(Vector3.down * Time.deltaTime * 4.0f);

            //return every frame
            yield return true;

        }

        StartCoroutine(FireLaser());

    }

    //Control the fire of the enemy laser
    private IEnumerator FireLaser(){

        //Always
        while (true){

            //Make the facilitators audio source play the attack sound
            GameObject.Find("Facilitator").GetComponent<AudioSource>().clip = attackSound;
            GameObject.Find("Facilitator").GetComponent<AudioSource>().Play();

            //Vector3 that stores where the laser should spawn according to where the enemy is at on the x axis
            Vector3 laserPosition = new Vector3(transform.position.x, transform.position.y - 1.1f, 0.0f);

            //Create the laser and put it in the position determined by the laserPosition vector
            Instantiate(currentLaser, laserPosition, currentLaser.transform.rotation);

            //Wait for a new rate of fire
            yield return new WaitForSeconds(fireRate);

        }

    }


}
