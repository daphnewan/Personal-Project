using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] objects;
    public GameObject powerup;

    private float xEnemySpawn = 10.0f;
    private float ySpawnRange = 7.0f;
    private float xPowerRange = 5.0f;
    private float zSpawn = 0.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float randomY = Random.Range(-ySpawnRange, ySpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomY, zSpawn, xEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);

    }
}
