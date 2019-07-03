using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    private int currentScore, highScore, currentLevel, maxLevel, levelAdder;
    public GameController gameController;
    public Text currentScoreText;
    public bool isHighScore;
    private void Start()
    {
        currentLevel = 10;
        levelAdder = 10;
        isHighScore = false;
        currentScore = 0;
        highScore = PlayerPrefs.GetInt("HighScore");
       
    }
    // Update is called once per frame
    
    public void ScoreCounter()
    {
        currentScore++;
        currentScoreText.text = "" + currentScore;
        
            if (currentScore > currentLevel)
            {
                gameController.IncreaseLevel();
                currentLevel = currentLevel + levelAdder;
            }
       

    }
    public void CheckHighScore()
    {
        if (currentScore > highScore)
        {
            highScore = currentScore;
            isHighScore = true;
        }
        PlayerPrefs.SetInt("HighScore", highScore);
        
        

    }
  
}
