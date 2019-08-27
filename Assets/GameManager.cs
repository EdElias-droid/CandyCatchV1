using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// went dealing with UI
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField]
    public GameObject livesHolder;
    public GameObject gameOverPanel;

    int score = 0;
    int lives = 3;
    bool gameOver = false;
    public Text scoreText;

private void Awake()
{
    instance = this;
}

    public void IncrementScore()
    {
       if(!gameOver)
       {
            score++;
            scoreText.text = score.ToString();
       }
        // score++;
        // scoreText.text = score.ToString();
        //    print(score);
    }
    public void DecreaseLife()
    {
        if(lives>0)
        {
            lives--;
            print(lives);

            livesHolder.transform.GetChild(lives).gameObject.SetActive(false);
        }
        if(lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }
    void GameOver()
    {
        SpawnerCandy.instance.StopSpawningCandies();
//        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
        print("THis is Game Over panel");
    }
}
