using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheMagnumOpus : MonoBehaviour 
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("A"))
        {
            Debug.Log("the magnus opus");
        }
    }

}
