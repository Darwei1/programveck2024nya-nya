using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class SpawnManager : GameManager
{

    public GameObject char_Prefab;

    public float timer;

    public void Update()
    {        

        if (yes == true && randomMaxAmountOfCharacters < 30) // om man kan spawna == true så spawna, samt skickar ut information, timern fungerar inte än, kommer att fortsätta utveckla koden senare
        {
            timer += Time.deltaTime;
            Debug.Log("Succesfully sent him awway, TO GLORYY!");
            yes = false;
            SpawnChar_Prefab();
        }
        if (no == true && randomMaxAmountOfCharacters < 30) // samma sak som det jag sa innan, kommer fortsätta vidare senare 
        {
            timer += Time.deltaTime;
            Debug.Log("Succesfully sent him awway, TO HIS DEATH!");
            no = false;
            SpawnChar_Prefab();

        }

    }



    public void SpawnChar_Prefab() // spawnar in gubbar,
    {
        randomMaxAmountOfCharacters++;
        DestroyPreviousCharacter();
        spawnedCharacter = Instantiate(char_Prefab, new Vector3(0, 3, 0), Quaternion.identity); // gör 
        Debug.Log("New character spawned SEND THEM TO HELL");
    }

    public void Start() // bara start function, inget speciellt.
    {
        spawnedCharacter = Instantiate(char_Prefab, new Vector3(0, 3, 0), Quaternion.identity);
        spawnPermit = true;

        yes = false;
        no = false;

        randomMaxAmountOfCharacters = Random.Range(7, 25);
        

    }



    public void Ja() // för att få knapparna att fungera i unity ui
    {
        yes = true;
        spawnPermit = true;
    }

    public void Nej()// för att få knapparna att fungera i unity ui
    {
        no = true;
        spawnPermit = true;
    }

}
