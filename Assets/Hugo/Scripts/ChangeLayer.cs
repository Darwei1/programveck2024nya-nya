using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
   
    public GameObject  rules;
    public GameObject instructions;
    
    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressRight()
    {
        if (rules == isActiveAndEnabled)
        {
            rules.SetActive(false);
        }
        else
        {
            rules.SetActive(true);
        }
    }
    public void OnButtonPressLeft()
    {
        
    }
}
