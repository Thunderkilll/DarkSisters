using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

    public float speed = 0f;
    public float distance = 3f;
    private Transform target;
    //public Transform target;
     
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector2.Distance(transform.position, target.position) <= distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime); //MoveToward(from , to , speed);
            if (Vector2.Distance(transform.position, target.position) <= 0.5)
            {
                Debug.Log("player damaged /  health --");
               

            }
        }
    }
}
