using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] CharacterPrefab;
    public GameObject latestCharacter;
    
    PassportGenerator passportGenerator;
    
    // Start is called before the first frame update
    void Start()
    {
        passportGenerator = GetComponent<PassportGenerator>();
        passportGenerator.Generate();
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
       latestCharacter = Instantiate(CharacterPrefab[Random.Range(0,CharacterPrefab.Length)], new Vector3(0, 1.71f, 0), Quaternion.identity);
      
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

    public void Dialogue()
    {
        GetComponent<DialogueManager>().StartDialogue();
        
    }
}
