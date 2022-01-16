using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int Score = 0;
    int Lives = 5;
    bool gameOver = false;
    public Text scoreText;
    public GameObject LivesHolder;
    public GameObject gameOverPanel;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScoreInc()
    {
        if (!gameOver)
        {
            Score++;
            scoreText.text = Score.ToString();
            //print(Score);
        }

    }
    
    public void DecreaseLives()
    {
        if(Lives > 0)
        {
            Lives--;
            //print(Lives);
            LivesHolder.transform.GetChild(Lives).gameObject.SetActive(false);
        }
        if(Lives <= 0)
        {
            gameOver = true;

            GameOver();
        }
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawning();
        GameObject.Find("Player").GetComponent<PlayerControl>().PlayerMove = false;
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
