using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {


    public int health;
    public GameObject destroyeffect;
    Scene scene;
    public Interract Interract;
    Animator animator;
    public void TakeDamage(int damage)

    {
        health -= damage;

    }
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update () {
        if (health <= 0)
        {
            Debug.Log("player is dead");
            Instantiate(destroyeffect, transform.position, Quaternion.identity);
           
            restartGameAfterDeath();
        }

       
    }
    void restartGameAfterDeath()
    {

        //turn this game ver to true )

        //Gameover.SetActive(true); //open the UI of gameover 
        //be able to restart after a time 
        
        // timeStamp = Time.time + cooldownSecs; //just a small cooldown 
        StartCoroutine(Waiting()); //waiting for some secs 


    }

    IEnumerator Waiting()
    {
        Interract.scorecappucin = 0;
        Interract.scorechicha = 0;
        Interract.scoretey = 0;
        Debug.Log("restart game 1 ");
        yield return new WaitForSeconds(10f);
        animator.SetBool("isDead", false);
        Destroy(gameObject);
        Debug.Log(scene.buildIndex);
        SceneManager.LoadScene(scene.buildIndex); //reload active scene 
        Debug.Log("restart game 2 ");

    }
}
