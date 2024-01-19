using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour //gjort av jack och anton
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject Object5;
    public GameObject Object6;


    public GameObject pass1;
    public GameObject pass2;
    public GameObject pass3;
    public GameObject pass4;

    public GameObject playerRef;
    

    public bool choice;
    public GameObject[] passports;

    List<GameObject> guests = new List<GameObject>();
    
    List<GameObject> Pass = new List<GameObject>();


    GameObject currentPassport;
    GameObject currentGuest;


    // Start is called before the first frame update
    void Start()
    {

        guests.Add(Object1);
        guests.Add(Object2);
        guests.Add(Object3);
        guests.Add(Object4);
        guests.Add(Object5);
        guests.Add(Object6);

        AssignNumbersToList(guests);

        AssignNumbersToList(Pass);

        GameObject objectFromListA = guests[0];
        GameObject objectFromListB = Pass[0];

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

    
}
