using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDspawner : MonoBehaviour
{
    public GameObject[] ID;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("firstSpawn", 4);
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

    void firstSpawn()
    {
        Instantiate(ID[Random.Range(0, ID.Length)], new Vector3(0, -2, 0), Quaternion.identity);
    }
}
