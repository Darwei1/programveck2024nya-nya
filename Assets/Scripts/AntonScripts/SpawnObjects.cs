using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float timer = 3f;//scary 3 second timer

    private bool countdown = true;//sets countdown to true

    void Start()
    {
        

    }

    void Update()
    {
        if (countdown)
        {
            timer -= Time.deltaTime;//countdown timer for when object is ready to be born into the world
            if (timer <= 0)//if timer hits zero force object to enter the scene against its will
            {
                Instantiate(objectToSpawn, new Vector3(0, 0, 0), Quaternion.identity);//Instatiate object at 0,0,0
                countdown = false;
            }
        }
        
    }
}
