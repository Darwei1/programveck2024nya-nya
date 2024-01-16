using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassportMatching : MonoBehaviour
{



    public bool choice;

    public GameObject gameobject1;
    public GameObject gameobject2;
    public GameObject gameobject3;
    // Start is called before the first frame update
    void Start()
    {


        if (gameobject1.CompareTag(gameobject2.tag) && gameobject1.CompareTag(gameobject3.tag))
        {
            print("Tags are equal.");
            choice = true;
        }
        else
        {
            print("Tags are not equal.");

            choice = false;
        }

    }

    private void Update()
    {

    }


}
