using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    private GameObject gameOverText;

    
    public AudioSource GameOver;
    public AudioSource BackgroundMusic;
    public AudioClip EndGameSound;
    public float Volume;
    public bool alreadyPlayed = false;

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame();  //Start EndGame Method
        }
        else
            gameOverText.gameObject.SetActive(false);  // Keep UI Text Game Over hidden
    }

    public void EndGame()
    {
        
        if (!alreadyPlayed)
        {
            GameOver.PlayOneShot(EndGameSound, Volume);
            Debug.Log("Played");
            alreadyPlayed = true;
        }
        gameOverText.gameObject.SetActive(true); //Activate Game Over text
        Time.timeScale = 0;  // Freeze Time
        BackgroundMusic.Stop();
    }


}
