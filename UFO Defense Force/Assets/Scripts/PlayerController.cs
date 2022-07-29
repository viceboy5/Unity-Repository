using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 40;

    public Transform blaster;
    public GameObject lazerBolt;

    public GameManager gameManager;

    public AudioSource BlasterSound;

    public AudioSource GameOver;


    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); //Reference GameManager script on GameManager object
    }
    // Update is called once per frame
    void Update()
    {
        //Initialize HotizontalInput to receive values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Move Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // Keep player within bounds
        //Left Side Wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }

        // Right Side Wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // if spacebar is pressed, fire lazerbolt
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)  // *Second condition gameManager.isGameOver prevents the player from shooting after isGameOver becomes true
        {
            //Creates lazerBolt at the blaster transform position maintaining the object's rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
            BlasterSound.Play();
        }

    }
    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    } 

    public void PlayGameOver()
    {
        if (gameManager.isGameOver == true)
            GameOver.Play();
        if (GameOver.isPlaying)
        {
            Debug.Log("Played");
        }
    }
}
