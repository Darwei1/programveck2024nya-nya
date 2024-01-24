using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTagChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("A"))
        {
            Debug.Log("Player is Correct");
        }
        else Debug.LogWarning("Player is Incorrect");


    }
}
