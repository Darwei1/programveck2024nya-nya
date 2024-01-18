using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;

    public GameObject pass1;
    public GameObject pass2;
    public GameObject pass3;
    public GameObject pass4;
    

    public bool choice;
    GameObject playerRef;
    public GameObject[] passports;

    List<GameObject> guests = new List<GameObject>();
    
    List<GameObject> Pass = new List<GameObject>(); 


    // Start is called before the first frame update
    void Start()
    {


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

   

 