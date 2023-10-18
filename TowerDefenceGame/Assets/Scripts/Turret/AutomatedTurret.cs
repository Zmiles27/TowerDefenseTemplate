using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class AutomatedTurret : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject enemyPrefab;

    private bool canShoot;

    public float shootDelay;

    private void Start()
    {
        canShoot = true;
    }

    private void OnTriggerStay2D()
    {
        // Checks locations of enemies and rotates the turret towards the Enemies
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0)
        {
            return;
        }
        else
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, targets[0].transform.position - transform.position);

            // shoots Bullets Towards Enemy
            if (canShoot == true)
            {
                canShoot = false;
                Instantiate(bulletPrefab, this.transform.position, Quaternion.LookRotation(Vector3.forward, targets[0].transform.position - transform.position));
                StartCoroutine(Delay());
            }
        }

        

        IEnumerator Delay()
        {
            yield return new WaitForSeconds(shootDelay / 10);
            canShoot = true;
        }
    }
}