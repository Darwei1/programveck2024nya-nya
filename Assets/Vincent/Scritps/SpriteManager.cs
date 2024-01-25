using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpriteManager : SpawnManager
{
    public SpriteRenderer sRend;
    public Sprite[] sprites;

    [Header("Dialogue")]
    public GameObject dialogue_Prefab;
    public TextMeshProUGUI textBox;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
            CreateDia();
        }

        
    }

    void Start()
    {
        sRend = gameObject.GetComponent<SpriteRenderer>();
    }

    void ChangeSprite()
    {
        sRend.sprite = sprites[Random.Range(0, sprites.Length)];
        Debug.Log(sRend.sprite);
    }
}
