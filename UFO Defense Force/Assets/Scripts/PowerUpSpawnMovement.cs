using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnMovement : MonoBehaviour
{
    public GameObject powerUp;
    public float spawnTime = 17f;
    public float xRange = 40;
    public float speed = 12;
    public GameObject powerUpSpawner;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerUp", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        //Left Side Wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }

    void SpawnPowerUp()
    {
        Instantiate(powerUp, powerUpSpawner.transform.position, powerUp.transform.rotation);
    }
    private void OnTriggerEnter(Collider Player)
    {
        Destroy(powerUp);
        Debug.Log("Added to inventory");
    }
}
