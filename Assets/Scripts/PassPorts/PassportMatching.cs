using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour //gjort av jack och anton
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;
    public GameObject object5;
    public GameObject object6;

    public GameObject pass1;
    public GameObject pass2;
    public GameObject pass3;
    public GameObject pass4;
    public GameObject pass5;
    public GameObject pass6;
    


    public bool choice;
    public GameObject[] passports;

    List<GameObject> G�ster = new List<GameObject>();
    
    List<GameObject> Pass = new List<GameObject>();


    GameObject currentPassport;
    GameObject currentGuest;


    // Start is called before the first frame update
    void Start()
    {
        currentGuest = GameObject.FindGameObjectWithTag("Guest");

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
    void AssignNumbersToList(List<GameObject> gameObjectsList)
    {
        for (int i = 0; i < gameObjectsList.Count; i++)
        {
            gameObjectsList[i].name = "Object " + i;
            Debug.Log(gameObjectsList[i].name + " assigned number: " + i);
        }
    }

    bool CompareObjectsFromDifferentLists(GameObject objA, GameObject objB)
    {
        int numberA = ExtractNumber(objA.name);
        int numberB = ExtractNumber(objB.name);

        return numberA == numberB;
    }

    
    bool CompareObjects(GameObject obj1, GameObject obj2)
    {
        int number1 = ExtractNumber(obj1.name);
        int number2 = ExtractNumber(obj2.name);

        return number1 == number2;
    }

    int ExtractNumber(string input)
    {
        int number = 0;
        string numberString = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                numberString += input[i];
            }
            else if (!string.IsNullOrEmpty(numberString))
            {
                break;
            }
        }

        int.TryParse(numberString, out number);

        return number;
    }

}

   

 