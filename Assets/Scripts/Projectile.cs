using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public GameObject destroyeffect; 
    private void Start()
    {
        Invoke("DestroyProjectile",lifeTime);
    }
    private void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }

    public void DestroyProjectile()
    {
        Instantiate(destroyeffect , transform.position , Quaternion.identity);
        Destroy(gameObject);
    }
}
