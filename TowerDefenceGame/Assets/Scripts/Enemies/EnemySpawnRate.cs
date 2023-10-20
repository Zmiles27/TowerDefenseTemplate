using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;

public class EnemySpawnRate : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDelay;
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
        if (spawnDelay < 3)
        {
            spawnDelay= 3;
        }
    }

    IEnumerator Delay()
    {
        Instantiate(enemyPrefab);
        yield return new WaitForSeconds(spawnDelay * 10 * Time.deltaTime);
        canSpawn = true;
    }

    public void ChangeDelay()
    {
        spawnDelay -= 1;
    }
}
