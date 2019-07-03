using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destory : MonoBehaviour
{
    [SerializeField]
    private GameController gameController;
    [SerializeField]
    private Score score;

   void OnCollisionEnter(Collision col)
   {
       if (col.gameObject.layer == 9)
       {

            // Destroy(col.gameObject);
            //gameController.objectCounter--;
            //Call the game over menu
            //TODO
            score.CheckHighScore();
            SceneManager.LoadScene("DeathMenu");
       }


    }
}
