using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour{

    //Stores the basic enemy object prefab
    public GameObject enemy;
    //Stores the harder enemy object prefab
    public GameObject enemyHard;
    //Stores the double enemy object prefab
    public GameObject enemyDouble;
    //Stores the power up prefabs
    public GameObject powerup;
    public GameObject health;
    //Stores the UI text for health
    public TextMeshProUGUI healthText;



    //Integer variable represents how many enemies are alive
    public int enemiesAlive = 0;

    //Integer variable that stores the current stage
    private int stage = ValueStorage.stagePoint;

    //Boolean variable that stores if the ending "animation" finished.
    private bool ending = false;



    //Every frame
    void Update(){

        //Make sure the health text on the screen is updated
        updateHealthText();

        //If there are no enemies alive
        if (enemiesAlive == 0){

            //Use a switch statement to check what stage it should be
            switch (stage){

                //Depending on the stage spawn the proper enemies
                case 0:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Setup variables for this stages enemies
                    enemy.GetComponent<EnemyScript>().enemySpeedGiven = 5.0f;
                    enemy.GetComponent<EnemyScript>().enemyHealthGiven = 1;
                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;
                    enemy.GetComponent<EnemyScript>().fireRateGiven = 2.5f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 1:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 2:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Change variables for this stages enemies
                    enemy.GetComponent<EnemyScript>().enemySpeedGiven = 6.5f;
                    enemy.GetComponent<EnemyScript>().fireRateGiven = 1.75f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 3:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 4:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 5:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 6:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Change variables for this stages enemies
                    enemyHard.GetComponent<EnemyScript>().enemySpeedGiven = 3.0f;
                    enemyHard.GetComponent<EnemyScript>().enemyHealthGiven = 3;
                    enemyHard.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemyHard.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;
                    enemyHard.GetComponent<EnemyScript>().fireRateGiven = 0.25f;

                    //Create the enemy
                    Instantiate(enemyHard, enemyHard.transform.position, enemyHard.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 7:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Change variables for this stages enemies
                    enemy.GetComponent<EnemyScript>().enemySpeedGiven = 8.0f;
                    enemy.GetComponent<EnemyScript>().fireRateGiven = 1.5f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 8:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 9:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 10:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Change variables for this stages enemies
                    enemyHard.GetComponent<EnemyScript>().enemySpeedGiven = 5.0f;

                    //Create the enemy
                    Instantiate(enemyHard, enemyHard.transform.position, enemyHard.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 11:

                    //Spawn a power up
                    Instantiate(powerup, powerup.transform.position, powerup.transform.rotation);

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 12:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 13:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 14:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive += 2;

                    enemy.GetComponent<EnemyScript>().fireRateGiven = 1.0f;
                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = -0.45f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = 0.45f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position + new Vector3(4.35f, 0f, 0f), enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 15:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive += 2;

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = -0.45f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = 0.45f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position + new Vector3(4.35f, 0f, 0f), enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 16:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive += 2;

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = -0.45f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = 0.45f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position + new Vector3(4.35f, 0f, 0f), enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 17:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemyHard, enemyHard.transform.position, enemyHard.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 18:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemyHard, enemyHard.transform.position, enemyHard.transform.rotation);

                    //Move stages for next time
                    stage++;

                    break;

                case 19:

                    //If not ending
                    if(ending == false){

                        //Get the player reference
                        GameObject player = GameObject.Find("Player");

                        //Start the Coroutine for ending
                        StartCoroutine(Ending(player));

                        //Indicate it is ending
                        ending = true;

                    }
                    //Else it is ending
                    else{

                        //And so should be staying at case 19 but leaving instead of starting the coroutine again
                        break;

                    }


                    break;

                case 20:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Setup variables for this stages enemies
                    enemy.GetComponent<EnemyScript>().enemySpeedGiven = 10.0f;
                    enemy.GetComponent<EnemyScript>().enemyHealthGiven = 1;
                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;
                    enemy.GetComponent<EnemyScript>().fireRateGiven = 1.5f;

                    gameObject.GetComponent<AsteroidManager>().spawnInterval = 1.5f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    //Leave the switch statement
                    break;

                case 21:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    break;

                case 22:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage++;

                    break;

                case 23:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Setup variables for this stages enemies
                    enemyDouble.GetComponent<EnemyScript>().enemySpeedGiven = 10.0f;
                    enemyDouble.GetComponent<EnemyScript>().enemyHealthGiven = 2;
                    enemyDouble.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemyDouble.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;
                    enemyDouble.GetComponent<EnemyScript>().fireRateGiven = 0.5f;
                    enemyDouble.GetComponent<EnemyScript>().divSpeedGiven = 4.00f;

                    //Create the enemy
                    Instantiate(enemyDouble, enemyDouble.transform.position, enemyDouble.transform.rotation);

                    //Move stages for next time
                    stage++;

                    break;

                case 24:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Spawn a health powerup
                    Instantiate(health, health.transform.position, health.transform.rotation);

                    //Move stage for next time
                    stage++;

                    break;

                case 25:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive += 2;

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = -0.45f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = 0.45f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position + new Vector3(4.35f, 0f, 0f), enemy.transform.rotation);

                    stage++;

                    break;

                case 26:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive += 2;

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = -0.45f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = 0.45f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position + new Vector3(4.35f, 0f, 0f), enemy.transform.rotation);

                    stage++;

                    break;

                case 27:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive += 2;

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = -0.45f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    enemy.GetComponent<EnemyScript>().enemySpaceStart = 0.45f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position + new Vector3(4.35f, 0f, 0f), enemy.transform.rotation);

                    stage++;

                    break;

                case 28:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Setup variables for this stages enemies
                    enemy.GetComponent<EnemyScript>().enemySpeedGiven = 10.0f;
                    enemy.GetComponent<EnemyScript>().enemyHealthGiven = 1;
                    enemy.GetComponent<EnemyScript>().enemySpaceStart = -3.9f;
                    enemy.GetComponent<EnemyScript>().enemySpaceEnd = 3.9f;
                    enemy.GetComponent<EnemyScript>().fireRateGiven = 1.5f;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    stage++;

                    break;

                case 29:

                    //If not ending
                    if (ending == false){

                        //Get the player reference
                        GameObject player = GameObject.Find("Player");

                        //Start the Coroutine for ending
                        StartCoroutine(Ending(player));

                        //Indicate it is ending
                        ending = true;

                    }
                    //Else it is ending
                    else{

                        //And so should be staying at case 19 but leaving instead of starting the coroutine again
                        break;

                    }

                    break;

                default:

                    //Leave the switch statement
                    break;

            }

        }

    }

    //Updates the score to account for changes
    void updateHealthText(){

        //If the player object exists
        if (GameObject.Find("Player") != null) {

            //Set the score text to reflect the current score variable
            healthText.text = "Lives: " + GameObject.Find("Player").GetComponent<PlayerController>().playerHealth;

        }
        //Else it doesn't, so
        else {

            //Set lives to 0
            healthText.text = "Lives: 0";

        }

    }

    //Once enemies are dead fly up and end the level
    private IEnumerator Ending(GameObject player){

        //While not at the top of the screen
        while (player.transform.position.y <= 5.0f){

            //Move up
            player.transform.Translate(Vector3.up * Time.deltaTime * 8.0f);

            //return every frame
            yield return true;

        }

        //Move the stage up
        stage++;

        //Tell the level select that the level is over
        ValueStorage.stagePoint = stage;

        //Go back to level select
        gameObject.GetComponent<LevelSelect>().LoadLevelSelect();

        //return after the while loop
        yield return true;

    }

}