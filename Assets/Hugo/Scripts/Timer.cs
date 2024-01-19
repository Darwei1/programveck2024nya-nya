using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300f;
    public GameObject canvas;
    bool timerIsRunning;
    float canvasAlpha;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        
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
                Invoke("deactivate", 2);

            }
            else
            {
                canvas.SetActive(true);
                canvas.GetComponent<CanvasGroup>().alpha += 0.5f * Time.deltaTime;
                
                Invoke("ChangeScene", 3);
            }
        }
        
        
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("ShopMenu");
    }

    void deactivate()
    {
        canvas.SetActive(false);
    }
}
