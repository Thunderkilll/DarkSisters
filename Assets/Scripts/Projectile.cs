using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public float distance;
    public GameObject destroyeffect;
    public LayerMask whatIsSolid;
    private void Start()
    {
        Invoke("DestroyProjectile",lifeTime);
    }
    private void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance , whatIsSolid);
        if (hitInfo.collider != null)
        {
            Debug.Log(hitInfo.collider.name);
            if (hitInfo.collider.CompareTag ("Enemy"))
            {
                Debug.Log(hitInfo.collider.name);
                Debug.Log("give enemy a bit of damage");
                DestroyProjectile();
            }
            
        }
        else
        {
            Debug.Log("not hitting anyone");
        }
        transform.Translate(transform.right * speed * Time.deltaTime);
         
    }

    public void DestroyProjectile()
    {
        // Instantiate(destroyeffect , transform.position , Quaternion.identity);
        Destroy(gameObject);
 
    }
}
