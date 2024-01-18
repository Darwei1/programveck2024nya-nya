using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpendingMenu : MonoBehaviour
{
    public GameObject menu;
    [SerializeField] private CanvasGroup myUIGroup;
    void Start()
    {
        //menu.SetActive(false);
    }

    public void CloseMenu()
    {
        if (myUIGroup.alpha <= 1)
        {
            myUIGroup.alpha -= 0.01f * Time.deltaTime;
        }
        menu.SetActive(false);
    }
    public void EndOfDay()
    {
        menu.SetActive(true);
        
        if (myUIGroup.alpha >= 1)
        {
            myUIGroup.alpha += 0.01f * Time.deltaTime;
        }
    }
}
