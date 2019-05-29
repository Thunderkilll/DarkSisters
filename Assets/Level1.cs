using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1 : MonoBehaviour {


    Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update () {

        loadScene();


    }
    void  loadScene()
    {


        StartCoroutine(Waiting()); //waiting for some secs 


    }

    IEnumerator Waiting()
    {


        yield return new WaitForSeconds(0.9f);
         
        SceneManager.LoadScene(scene.buildIndex +1); //reload active scene 
        Debug.Log("restart game 2 ");

    }
}
