using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathMenu : MonoBehaviour
{
    private int highScore, currentScore;
    public Text highScoreText;
    
    
    void Start()
    {
        
       
            highScore = PlayerPrefs.GetInt("HighScore");
            highScoreText.text = "" + highScore;
            
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClick()
    {
        SceneManager.LoadScene("Main");
    }
    public void Quit()
    {

        Application.Quit();

    }
}
