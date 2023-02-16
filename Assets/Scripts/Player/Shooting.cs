using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   
    public Transform firePoint1;
    public GameObject bulletPrefab;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
void Shoot()
{
Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
}

}
