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
   // public Interract Interract;
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
                    Debug.Log("player is dead");
                }

            }
            else
                animator.SetBool("isAttacking", false);
        }
    }



  
}
