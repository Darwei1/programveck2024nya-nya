using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : MonoBehaviour
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
        sRend.sprite = sprites[Random.Range(0, sprites.Length)];
        Debug.Log(sRend.sprite);
    }
}
