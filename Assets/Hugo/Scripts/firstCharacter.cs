using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstCharacter : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject CharacterPrefab;
    public bool CharacterOnScreen = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("firstSpawn", 3);
    }

    // Update is called once per frame
    
    void firstSpawn()
    {
        Instantiate(CharacterPrefab, new Vector3(0, 1.71f, 0), Quaternion.identity);
        CharacterOnScreen = true;
    }

    private void Update()
    {
        if (CharacterOnScreen == true)
        {
            dialogue.GetComponent<DialogueManager>().Invoke("StartDialogue", 0);
            print("he is among us");

        }
    }
}
