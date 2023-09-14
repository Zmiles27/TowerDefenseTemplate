using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;

    private bool canShoot;

    private void Start()
    {
        canShoot= true;
    }

    void Update()
    {
        //Aims Turret at mousePointer
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        bulletPrefab.transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        if (canShoot == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletPrefab);
            }
        }
    }
}
