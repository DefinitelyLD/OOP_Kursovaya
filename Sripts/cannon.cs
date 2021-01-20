using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float CanShootafter = 0f;
    public float ShootInterval = 5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > CanShootafter)  //якщо час до пострілу менше інтервалу мміж пострілами - постріл
        {
            CanShootafter = Time.time + ShootInterval;
            Shoot();
                
        }
    }

    void Shoot() 
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); //спавнимо кулю
    }
}
