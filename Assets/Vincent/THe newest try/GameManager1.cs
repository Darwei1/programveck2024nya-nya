using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : ButtonManager
{
    [Header("Character Prefab Array")]
    public GameObject[] char_Goods;
    public GameObject[] char_Evils;
    public GameObject latest_obj;

    public void Awake()
    {

        print("helo");

        print("helo");

        isButtonYes = false;
        isButtonNo = false;
    }

    public void Char_SpawnGood()
    {
        
        latest_obj = Instantiate(char_Goods[Random.Range(0, char_Goods.Length)], new Vector3(0, 0, -5), Quaternion.identity);
   

    }
    public void Char_SpawnEvil()
    {
        Destroy(latest_obj);
        latest_obj = Instantiate(char_Evils[Random.Range(0, char_Evils.Length)], new Vector3(0, 0, -5), Quaternion.identity);
        

    }

    public void DestroyObj()
    {

        Destroy(latest_obj, 2);

    }

}
