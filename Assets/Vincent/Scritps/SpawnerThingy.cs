using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerThingy : MonoBehaviour // rånad från hugo (jag skapade inte det här)
{
    public GameObject[] CharacterPrefab;

    public GameObject dialoguePrefab;
    public GameObject latestCharacter;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Spak()
    {
        int i;
        i = Random.Range(0, 2);
        //  int[Random.Range] rand = { 0, 1, 2 };
    }

    public void Spawn()
    {
        Instantiate(dialoguePrefab, new Vector3(-8, -497, 0), Quaternion.identity);
        latestCharacter = Instantiate(CharacterPrefab[Random.Range(0, CharacterPrefab.Length)], new Vector3(0, 1.71f, 0), Quaternion.identity);
    }

    public void spawnTimer()
    {

        latestCharacter = GameObject.FindGameObjectWithTag("guest");
        Invoke("Animation1", 0);

        offScreenDestroy(latestCharacter);
        Invoke("Spawn", 3);
    }
    public void spawnTimer2()
    {
        latestCharacter = GameObject.FindGameObjectWithTag("guest");
        Invoke("Animation2", 0);

        offScreenDestroy(latestCharacter);
        Invoke("Spawn", 3);
    }
    public void Animation1()
    {
        latestCharacter.GetComponent<Animator>().Play("animation1");
    }
    public void Animation2()
    {
        latestCharacter.GetComponent<Animator>().Play("animation2");
    }
    void offScreenDestroy(GameObject objectToDestroy)
    {
        Destroy(objectToDestroy, 1);
    }

    void firstSpawn()
    {
        //Instantiate(CharacterPrefab, new Vector3(0, 1.71f, 0), Quaternion.identity);
        //print("ballsack");

    }
}


