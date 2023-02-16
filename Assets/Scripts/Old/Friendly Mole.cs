using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friendly_MoleClass : MonoBehaviour
{


//this is the zombie script & health stats

    public GameObject player;
    public int health = 100;
    public GameObject deathEffect;
    public float speed;
    public float distance;

//an introduction cutscene with text boxes and animations for the friendlyMole

    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance >=1){
//run and face towards player
     
        speed = 0;

        }

        else{
        
   
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
        
        
    }

}
