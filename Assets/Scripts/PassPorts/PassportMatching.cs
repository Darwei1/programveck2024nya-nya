using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour
{

    public List<GameObject> allowedObjects;
    public GameObject objectToCheck;
    


    // Start is called before the first frame update
    void Start()
    {
        CheckObject();

        GameObject Testguest = GameObject.FindWithTag("A");

        objectToCheck = Testguest.GetComponent<GameObject>();
    }

    private void Update()
    {
        if (gameObject.CompareTag("A"))
        {
            print("matching");
        }
        else
        {
            print("not matching");
        }

        
    }

    void CheckObject()
    {
        if (objectToCheck != null && allowedObjects.Contains(objectToCheck))
        {
            Debug.Log(objectToCheck.name + " is allowed.");
        }
        else
        {
            Debug.Log(objectToCheck.name + " is not allowed.");
        }
    }
}
