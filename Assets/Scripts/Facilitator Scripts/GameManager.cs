using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{

    //Stores the basic enemy object prefab
    public GameObject enemy;
    //Stores the harder enemy object prefab
    public GameObject enemyHard;


    //Integer variable represents how many enemies are alive
    public int enemiesAlive = 0;

    //Integer variable that stores the stage
    private int stage = 0;



    //Every frame
    void Update(){

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
                    stage = 1;

                    //Leave the switch statement
                    break;

                case 1:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 2;

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
                    stage = 3;

                    //Leave the switch statement
                    break;

                case 3:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 4;

                    //Leave the switch statement
                    break;

                case 4:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 5;

                    //Leave the switch statement
                    break;

                case 5:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 6;

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
                    stage = 7;

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
                    stage = 8;

                    //Leave the switch statement
                    break;

                case 8:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 9;

                    //Leave the switch statement
                    break;

                case 9:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 10;

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
                    stage = 11;

                    //Leave the switch statement
                    break;

                case 11:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 12;

                    //Leave the switch statement
                    break;

                case 12:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 13;

                    //Leave the switch statement
                    break;

                case 13:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);

                    //Move stages for next time
                    stage = 14;

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
                    stage = 15;

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
                    stage = 16;

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
                    stage = 17;

                    //Leave the switch statement
                    break;

                case 17:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemyHard, enemyHard.transform.position, enemyHard.transform.rotation);

                    //Move stages for next time
                    stage = 18;

                    //Leave the switch statement
                    break;

                case 18:

                    //Indicate that there are currently enemies alive as to not change stages
                    enemiesAlive++;

                    //Create the enemy
                    Instantiate(enemyHard, enemyHard.transform.position, enemyHard.transform.rotation);

                    //Move stages for next time
                    stage = 19;

                    break;

                default:

                    //Leave the switch statement
                    break;

            }

        }

    }

}
