using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadTagChecker : MonoBehaviour 
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("B"))
        {
            Debug.Log("Player is Correct");
        }
        else Debug.LogWarning("Player is Incorrect");
        

    }

}
