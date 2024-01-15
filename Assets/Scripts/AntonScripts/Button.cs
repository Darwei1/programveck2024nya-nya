using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject objectToSpawn;


    private bool spawn = true;// its true
   


    public void OnButtonPress()
    {
        if (spawn==true)
        {
            Instantiate(objectToSpawn, new Vector3(3, -3, 0), Quaternion.identity);//spawn object at 3,-3,0
            spawn = false;//stops more from being able to instantiate
        }
       
    }
}
