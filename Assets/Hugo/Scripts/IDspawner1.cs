using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDspawner1 : MonoBehaviour
{
    public GameObject[] ID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void TimedSpawn()
    {
        Invoke("idSpawn", 5);
    }

    public void idSpawn()
    {
        Instantiate(ID[Random.Range(0, ID.Length)], new Vector3(0, -2, 0), Quaternion.identity);
    }

    
}
