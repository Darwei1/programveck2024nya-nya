using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : TagChecker200
{

    GameManager1 gMan;

    [Header("True or False Statements")]
    public bool isButtonYes;
    public bool isButtonNo;

    public void Yes()
    {
        
        if (isGood == true)
        {
            print("+1");
        }
        else if  (isEvil == true)
        {
            print("-1");
        }
        isEvil = false;
        isGood = false;
        Destroy(gMan.latest_obj);

        // random spawn chans
        int rng = Random.Range(0, 2);
        if (rng == 1)
        {
            gMan.Char_SpawnGood();
        }
        else
        {
            gMan.Char_SpawnEvil();
        }
    }

    public void No()
    {
        if (isGood == true)
        {
            print("-1");
        }
        if (isEvil == true)
        {
            print("+1");
        }
        isEvil = false;
        isGood = false;
        Destroy(gMan.latest_obj);



        // random spawn chans
        int rng = Random.Range(0, 2);
        if (rng == 1)
        {
            gMan.Char_SpawnGood();
        }
        else
        {
            gMan.Char_SpawnEvil();
        }

    }

    private void Start()
    {
        gMan = GetComponent<GameManager1>();
    }

}
