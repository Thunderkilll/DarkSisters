﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    public int health;
    public void TakeDamage(int damage)
    {
        health -= damage;
      
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (health <= 0)
        {
            Debug.Log("enemy is dead");
            Destroy(gameObject);
        }
    }
}
