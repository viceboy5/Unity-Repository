using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnManager : MonoBehaviour
{
    public GameObject[] powerUpPrefabs;
    
    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 2f;

    private float spawnInterval = 1.5f;

    
    void Start()
    {
        InvokeRepeating("SpawnRandomPowerUp", startDelay, spawnInterval);
    }

    void SpawnRandomPowerUp()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
        int powerUpIndex = Random.Range(0, powerUpPrefabs.Length); // Picks a random Powerup from the array
        Instantiate(powerUpPrefabs[powerUpIndex], spawnPos, powerUpPrefabs[powerUpIndex].transform.rotation); //Spawns an indexed Powerup from the array at a random location on the X-axis
    }
    private void OnTriggerEnter(Collider Player)
    {
        Destroy(gameObject);
        Debug.Log("Added to inventory");
    }
}
