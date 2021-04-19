using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    //Stores the current type of laser the player is using
    public GameObject currentLaser;



    //Float variable that stores the speed the player moves left and right
    public float playerSpeed = 8.0f;
    //Float variable that stores if the player wants to move left or right, or is not moving at all
    private float horizontalInput;

    //Float variables that limit how often the player can fire a laser
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    //Integer variable that stores player health
    public int playerHealth = 3;



    //Initialization
    private void Start(){

        StartCoroutine(MoveUp());

    }

    //Every frame
    void Update(){

        //Move the player
        UpdateMovement();
        //Shoot lasers
        FireLaser();

    }

    //Control player movement each frame
    void UpdateMovement(){

        //Consistantly store the users input into the horizontalInput variable
        horizontalInput = Input.GetAxis("Horizontal");


        //Move the player object every second  right or left by the speed set by the playerSpeed variable and depending on the input of the user
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);

        //If the player moves to far to the left
        if (transform.position.x < -8.0f){

            //fix their position to stop them from going any further
            transform.position = new Vector3(-8.0f, transform.position.y, transform.position.z);

        }
        //Else if the player moves to far to the right
        else if (transform.position.x > 8.0f){

            //fix their position to stop them from going any further
            transform.position = new Vector3(8.0f, transform.position.y, transform.position.z);

        }

    }

    //Fire a laser
    void FireLaser(){

        //If the space bar is pressed within time limits
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){

            //Update the timer for the delay
            nextFire = Time.time + fireRate;


            //Vector3 that stores where the laser should spawn according to where the player is at on the x axis
            Vector3 laserPosition = new Vector3(transform.position.x, transform.position.y + 1.0f, 0.0f);

            //Create the laser and put it in the position determined by the laserPosition vector
            Instantiate(currentLaser, laserPosition, currentLaser.transform.rotation);

        }


    }

    //Check if the player should be dead
    private void OnTriggerEnter(Collider other){

        //Destroy the other object
        Destroy(other.gameObject);

        //If the enemy hits a power up
        if (other.CompareTag("Powerup")){

            //Fire twice as fast
            fireRate /= 3.0f;

            //Start a coroutine that eventually ends the effect
            StartCoroutine(PowerupControl());

        }
        //Else it is an enemy laser or asteroid so
        else{

            //Make the player lose a point of health
            playerHealth--;

            //If the player was hit 3 times
            if (playerHealth == 0){

                //Destroy the player object (TEMP)
                Destroy(gameObject);

            }

        }

    }

    //Manage a players power up
    IEnumerator PowerupControl(){

        //After 10 seconds
        yield return new WaitForSeconds(10);

        //They no longer have the power
        fireRate *= 3;
        

    }

    //Intro section to move forward into scene
    private IEnumerator MoveUp(){

        //While not at the player position
        while (transform.position.y <= -4.0f){

            //Move up
            transform.Translate(Vector3.up * Time.deltaTime * 4.0f);

            //return every frame
            yield return true;

        }

    }

}
