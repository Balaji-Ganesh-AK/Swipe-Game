using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{
    private int highScore;
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
}
