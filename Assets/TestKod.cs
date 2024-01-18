using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestKod : MonoBehaviour
{// skapad av vincent den här koden är bara för att testa inget mer, inget viktigare


    public GameObject dialogue;

    private void Start()
    {

        Instantiate(dialogue, transform.position, Quaternion.identity);


    }
    private void Update()
    {
        if (dialogue.gameObject == null)
        {
            Instantiate(dialogue, transform.position, Quaternion.identity);
        }
    }

}
