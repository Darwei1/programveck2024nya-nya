using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerGoobs : DialogueManager
{
    public GameObject CharacterPrefab;
    public GameObject latestCharacter;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

 

    public void Spawn()
    {
        latestCharacter = Instantiate(CharacterPrefab, new Vector3(0, 1.71f, 0), Quaternion.identity);
        StartDialogue();
    }

    public void spawnTimer()
    {

        latestCharacter = GameObject.FindGameObjectWithTag("guest");
        Invoke("Animation1", 0);

        offScreenDestroy(latestCharacter);
        Invoke("Spawn", 5);
    }
    public void spawnTimer2()
    {
        latestCharacter = GameObject.FindGameObjectWithTag("guest");
        Invoke("Animation2", 0);

        offScreenDestroy(latestCharacter);
        Invoke("Spawn", 5);
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

}
