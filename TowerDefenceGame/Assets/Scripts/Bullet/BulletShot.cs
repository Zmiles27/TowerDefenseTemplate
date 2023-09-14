using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShot : MonoBehaviour
{
    public float bulletSpeed;


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * bulletSpeed;
    }
}
