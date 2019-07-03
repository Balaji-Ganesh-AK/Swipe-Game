using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public Swipe swipeManager;
    public Score score;
    
    [SerializeField]
    private GameObject tap, swipeUp, swipeDown, swipeRight, swipeLeft;

    //magicnumber
    private float reducer = 0.25f;




    private int touchID, randomNumber;
    private float currentTime, timeToSpawn ;
    public float level = 2f;
    private int objectCounter;
    private bool spawned = false;
    //Change testing change i to private later
    private int i;
    Dictionary<int, GameObject> ID = new Dictionary<int, GameObject>();
    
    private GameObject[] objectHolder = new GameObject[3];
    private GameObject temp =null;
    private void Start()
    {
        
        objectCounter = 0;
        i = 0;
        timeToSpawn = 0;
        ID.Add(1,tap);
        ID.Add(2,swipeUp);
        ID.Add(3, swipeDown);
        ID.Add(4,swipeRight);
        ID.Add(5,swipeLeft);
      //  InvokeRepeating("SpawnController",0.0f, level);
       
    }

    private void Timer()
    {
        currentTime = Time.time;
        if (currentTime > timeToSpawn)
        {
            Debug.Log(currentTime);
            SpawnController();
            timeToSpawn = timeToSpawn + level;
        }
    }
    public void SpawnController()
    {
        if (objectCounter < 3)
        {
            
            randomNumber = Random.Range(1, 6);
            
            objectHolder[i]=(Instantiate(ID[randomNumber], transform.position,Quaternion.identity));
           
            i++;
            objectCounter++;
            spawned = true;
           
        }
        
    }
    
    private void Update()
    {


        touchID = 0;
        Timer();
        if (swipeManager.Tap)
        {
            touchID = 1;
        }
        if (swipeManager.SwipeUp)
        {
            touchID = 2;
        }
        if (swipeManager.SwipeDown)
        {
            touchID = 3;
        }
        if (swipeManager.SwipeRight)
        {
            touchID = 4;
            
        }
        if (swipeManager.SwipeLeft)
        {
            touchID = 5;
        }
        DestroyOnTouch(touchID);
    }
    public void DestroyOnTouch(int touchIDToDestroy)
    {
        
        if (touchIDToDestroy != 0)
        {

            if (spawned == true)
            {
                if (objectHolder[0] == null)
                {
                    //NUll handler;
                }

                else if (objectHolder[0].tag == ID[touchIDToDestroy].tag)
                {
                    // remove object in 0 and move other by one
                    temp = objectHolder[0];
                    if (objectHolder[1] != null)
                    {
                        objectHolder[0] = objectHolder[1];
                        objectHolder[1] = objectHolder[2];
                        objectHolder[2] = null;
                    }
                    else
                        objectHolder[0] = null;

                     Destroy(temp);
                    i--;
                    objectCounter--;

                    score.ScoreCounter();
                   
                  
                }
                
            }
        }
    }
    public void  IncreaseLevel()
    {
        if(level >.5f)
            level = level - reducer;
    }
    

}
