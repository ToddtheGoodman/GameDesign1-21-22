using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public bool enemyReady;

    public Transform spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        enemyReady = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyReady)
        {
            StartCoroutine("EnemySpawnDelay");
        }
        
    }

    IEnumerator EnemySpawnDelay()
    {
        enemyReady = false;
        yield return new WaitForSeconds(3);
        Instantiate(enemy, spawnLocation.position, Quaternion.identity);
        enemyReady = true;
    }

}
