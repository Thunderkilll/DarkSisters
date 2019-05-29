using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {


    public int health;
 
    Scene scene;
    public Interract Interract;
    public Animator animator;
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
            animator.SetBool("isDead", true);
            
            Interract.scorecappucin = 0;
            Interract.scorechicha = 0;
            Interract.scoretey = 0;
            Debug.Log("restart game 1 ");
            
            Debug.Log(scene.buildIndex);
            SceneManager.LoadScene(scene.buildIndex); //reload active scene 
            Debug.Log("restart game 2 ");
            Destroy(gameObject);
       
        }

       
    }
    void restartGameAfterDeath()
    {

       
        StartCoroutine(Waiting()); //waiting for some secs 


    }

    IEnumerator Waiting()
    {
        
         
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("isDead", false);
        Debug.Log(scene.buildIndex);
        SceneManager.LoadScene(scene.buildIndex); //reload active scene 
        Debug.Log("restart game 2 ");

    }
}
