﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float offset;
    public GameObject projectile;
    public Transform shootpoint; 
 
	// Update is called once per frame
	void Update () {
        //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
      //  float rotz = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
      //  transform.rotation = Quaternion.Euler(0f, 0f, rotz + offset);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectile, shootpoint.position, transform.rotation);
        }
	}
}
