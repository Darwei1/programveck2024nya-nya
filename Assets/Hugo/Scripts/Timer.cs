using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300f;
    public GameObject canvas;
    bool timerIsRunning;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        canvas.GetComponent<CanvasGroup>().alpha = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                canvas.GetComponent<CanvasGroup>().alpha -= 0.5f * Time.deltaTime;


            }
            else
            {
                canvas.GetComponent<CanvasGroup>().alpha += 0.5f * Time.deltaTime;
                
                
            }
        }
        
    }
}
