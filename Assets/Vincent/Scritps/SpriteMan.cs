using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMan : MonoBehaviour // rånad från hugo
{

    public SpriteRenderer sRend;
    public Sprite[] sprites;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
        }
    }

    void Start()
    {
        sRend = gameObject.GetComponent<SpriteRenderer>();
    }

    void ChangeSprite()
    {
        sRend.sprite = sprites[Random.Range(0,sprites.Length)];
    }


























    /* public GameObject[] CharacterPrefab;
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

    void firstSpawn()
    {
        //Instantiate(CharacterPrefab, new Vector3(0, 1.71f, 0), Quaternion.identity);
        //print("ballsack");

    } */
}
