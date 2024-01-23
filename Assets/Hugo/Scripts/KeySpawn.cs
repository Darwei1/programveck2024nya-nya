using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject objectToSpawn;

    // public Spawner spawnerScript;

    public GameObject key;

    public bool spawn = true;// its true
    // Start is called before the first frame update

    private void Start()
    {
        key = GameObject.FindGameObjectWithTag("D");
    }
    private void Update()
    {
        if ( key == null)
        {
            spawn = true;
        }
    }
    public void OnButtonPress()
    {
        if (spawn == true)
        {
            Instantiate(objectToSpawn, new Vector3(3, -3, 0), Quaternion.Euler(0, 0, -90));
            spawn = false;
        }

    }
}
