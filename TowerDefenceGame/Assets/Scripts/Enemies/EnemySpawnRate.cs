using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class EnemySpawnRate : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int spawnDelay;
    private bool canSpawn;




    private void Start()
    {
        canSpawn = true;
    }

    private void Update()
    {
        if(canSpawn == true)
        {
            canSpawn = false;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        Instantiate(enemyPrefab);
        yield return new WaitForSeconds(spawnDelay);
        yield return new WaitForSeconds(spawnDelay);
        canSpawn = true;
    }

}
