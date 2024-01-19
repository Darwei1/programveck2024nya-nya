using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour
{
    public bool choice;
    GameObject playerRef;
    public GameObject[] passports;

    List<GameObject> guests = new List<GameObject>();
    
    List<GameObject> Pass = new List<GameObject>();


    GameObject currentGuest;
    GameObject currentPass;


    // Start is called before the first frame update
    void Start()
    {
        playerRef = GameObject.FindWithTag("guest");


        AssignNumbersToList(guests);

        AssignNumbersToList(Pass);

        GameObject objectFromListA = guests[0];
        GameObject objectFromListB = Pass[0];

        currentGuest = gameObject;
        currentPass = GameObject.FindGameObjectWithTag("A");

        if (CompareObjectsFromDifferentLists(objectFromListA, objectFromListB))
        {
            Debug.Log(objectFromListA.name + " and " + objectFromListB.name + " have matching numbers.");
        }
        else
        {
            Debug.Log(objectFromListA.name + " and " + objectFromListB.name + " have different numbers.");
        }
    }

    private bool CompareObjectsFromDifferentLists(GameObject objectFromListA, GameObject objectFromListB)
    {
        throw new NotImplementedException();
    }

    void AssignNumbersToList(List<GameObject> gameObjectsList)
    {
        for (int i = 0; i < gameObjectsList.Count; i++)
        {
            gameObjectsList[i].name = "Object " + i;
            Debug.Log(gameObjectsList[i].name + " assigned number: " + i);
        }
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
