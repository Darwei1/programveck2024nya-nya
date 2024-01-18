using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChecker200 : MonoBehaviour
{

    public bool isEvil;
    public bool isGood;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Good"))
        {
            isGood = true;
            isEvil = false;
            print("Good");
        }
        else
        {
            isEvil = true;
            isGood = false;
            print("Evil");
        }


    }

    private void Awake()
    {
        isEvil = false;
        isGood = false;
    }

}
