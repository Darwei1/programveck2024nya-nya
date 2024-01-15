using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject objectToSpawn;


    private bool spawn = true;// its true
    // Start is called before the first frame update
    public void OnButtonPress()
    {
        if (spawn == true)
        {
            Instantiate(objectToSpawn, new Vector3(3, -3, 0), Quaternion.Euler(0, 0, -90));
            spawn = false;//stops more from being able to instantiate
        }

    }
}
