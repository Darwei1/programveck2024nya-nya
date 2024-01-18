using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour
{
    public bool choice;
    GameObject playerRef;
    public GameObject[] passports;

    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindWithTag("guest");


        //compareLayers();
    }

    private void Update()
    {
        for (int i = 0; i < passports.Length; i++)
        {
            if (passports[i].layer == playerRef.layer)
            {
                print("ARE MATCHING!");
            }
            else
            {
                print("ARE NOT MATCHING!");
            }
        }
    }

    void compareLayers()
    {
        for (int i = 0; i < passports.Length; i++)
        {
            if (passports[i].layer == playerRef.layer)
            {
                print("ARE MATCHING!");
            }
            else
            {
                print("ARE NOT MATCHING!");
            }
        }
    }
}
