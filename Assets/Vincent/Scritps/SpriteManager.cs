using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpriteManager : MonoBehaviour
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
        }

        
    }

    void Start()
    {
        sRend = gameObject.GetComponent<SpriteRenderer>();
        textBox = dialogue_Prefab.GetComponentInChildren<TextMeshProUGUI>();

        Instantiate(dialogue_Prefab, transform.position, Quaternion.identity);
    }

    void ChangeSprite()
    {
        sRend.sprite = sprites[Random.Range(0, sprites.Length)];
        Debug.Log(sRend.sprite);
    }
}
