using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    public Swipe swipeManager;
    [SerializeField]
    private GameObject tap, swipeUp, swipeDown, swipeRight, swipeLeft;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (swipeManager.SwipeUp)
        {
            Instantiate(swipeUp, transform.position, Quaternion.identity);
        }
        if (swipeManager.SwipeDown)
        {
            Instantiate(swipeDown, transform.position, Quaternion.identity);
        }
        if (swipeManager.SwipeLeft)
        {
            Instantiate(swipeLeft, transform.position, Quaternion.identity);
        }
        if (swipeManager.SwipeRight)
        {
            Instantiate(swipeRight, transform.position, Quaternion.identity);
        }
        if (swipeManager.Tap)
        {
            Instantiate(tap, transform.position, Quaternion.identity);
        }

    }
}
