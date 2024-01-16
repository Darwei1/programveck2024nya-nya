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


        if (gameobject1.layer == gameobject2.layer || gameobject1.layer == gameobject3.layer)
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
