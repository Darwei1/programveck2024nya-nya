using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SpawnManager : MonoBehaviour
{

    public static SpawnManager spawnInstance;
    public GameObject[] dialoguePrefabs;
    private GameObject newCharacter;
    public Transform obj;
    
    public void CreateDia()
    {
        GameObject newPrefabInstance = Instantiate(dialoguePrefabs[Random.Range(0,dialoguePrefabs.Length)], transform.position, Quaternion.identity);
    }

}
