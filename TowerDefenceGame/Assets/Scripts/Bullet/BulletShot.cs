using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    Counters counter;
    // TurretSpawn turretSpawn; 
    public float bulletSpeed;
    void Start()
    {
        counter = FindObjectOfType<Counters>();
        // turretSpawn = FindObjectOfType<TurretSpawn>();
        Destroy(gameObject, 2);
    }

    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            counter.scoreSystem(10);
            counter.pointSystem(1);
            counter.waveSystem(1);
                        
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
