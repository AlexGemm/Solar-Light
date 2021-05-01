using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){

        StartCoroutine(ScenePlayer());

    }

    // Update is called once per frame
    private IEnumerator ScenePlayer(){

        yield return new WaitForSeconds(3.5f);

        SceneManager.LoadScene("Earth");


    }
}
