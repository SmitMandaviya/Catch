using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public static Logic instace;

    public int playerScore = 0;

    public Text txtScore;

    public GameObject gameOver;

    private void Awake()
    {
        instace = this;    
    }

    public void Start()
    {
        txtScore.text = playerScore.ToString();
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
    }
    public void Score(int score)
    {
        playerScore += score;
        txtScore.text = playerScore.ToString(); 
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
