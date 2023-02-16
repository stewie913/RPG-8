using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{


//this is the zombie script & health stats

    public GameObject player;
    public int health = 100;
    public GameObject deathEffect;
    public float speed;
    private float distance;
    void Update()
    {
        //run and face towards player
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        
    }
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0 )        
        {
            Die();
        }
    }
    void Die ()
    {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

    }

}
