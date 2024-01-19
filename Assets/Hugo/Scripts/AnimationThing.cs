using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationThing : MonoBehaviour
{
    public bool Active = false;
    GameObject list;
    // Start is called before the first frame update
    void Start()
    {
        list = GameObject.FindWithTag("List");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Active == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {

                list.GetComponent<Animator>().Play("New Animation 0");
                print("ballsack");
                Active = true;

            }
        }
        if (Active == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                list.GetComponent<Animator>().Play("New Animation2");
                Active = false;
            }
        }
       
    }
}
