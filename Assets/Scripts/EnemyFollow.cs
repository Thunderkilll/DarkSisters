using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour {

    public float speed = 0f;
    public float distance = 3f;
    public int damage = 1 ;
    private Transform target;
    public Animator animator;
    public Image imageUiHealth;
    Scene scene;
    public Interract Interract;
    //public Transform target;

    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        scene = SceneManager.GetActiveScene();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, target.position) <= distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); //MoveToward(from , to , speed);
            if (Vector2.Distance(transform.position, target.position) <= 1)
            {
                if (imageUiHealth.fillAmount > 0)
                {
                    Debug.Log("enemy attacking player");
                animator.SetBool("isAttacking", true);
                target.GetComponent<Player>().TakeDamage(damage);
                imageUiHealth.fillAmount -= (float)damage / 100;


                }
                else
                {
                    restartGameAfterDeath();
                }

            }
            else
                animator.SetBool("isAttacking", false);
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
        Debug.Log(scene.buildIndex);
        SceneManager.LoadScene(scene.buildIndex); //reload active scene 
        Debug.Log("restart game 2 ");

    }
}
