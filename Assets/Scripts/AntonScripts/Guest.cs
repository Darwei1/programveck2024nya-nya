using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guest : MonoBehaviour
{

    public GameObject objectToSpawn;


    public Button buttonScript;

    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))//press F, do action
        {
            Instantiate(objectToSpawn, new Vector3(0, 4, 0), Quaternion.identity);//Instatiate object at 0,4,0
            buttonScript.spawn = true;
        }

        
    }
}
