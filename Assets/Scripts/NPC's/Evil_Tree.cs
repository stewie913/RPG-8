using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evil_Tree : MonoBehaviour
{


//this is the zombie script & health stats
    public Animator animator;
    public GameObject player;
    public int health = 100;
    public GameObject deathEffect;
    public float speed;
    public float distance;

//an introduction cutscene with text boxes and animations for the friendlyMole

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance >=2 & distance <=15 ){
            animator.SetFloat("Speed", speed);
        speed = 4;
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        //transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Horizontal", direction.x);

        }

    
     else{
        speed = 0;
        animator.SetFloat("Speed", speed);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
       // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
       // transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        animator.SetFloat("lastMoveX", direction.x);
        animator.SetFloat("lastMoveY", direction.y);

        }
        
        
    }

}
