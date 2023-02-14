using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed1 = 30f;
    public int damage = 40;
    public Rigidbody2D rb1;
    // Start is called before the first frame update
    void Start()
    {
        rb1.velocity = transform.right * speed1;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    
    {
             
        Zombie enemy = hitInfo.GetComponent<Zombie>();
        if (enemy != null){
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

}
