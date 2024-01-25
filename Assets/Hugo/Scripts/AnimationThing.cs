using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationThing : MonoBehaviour
{
    bool isActive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.B))
        {
            if (isActive)
            {
                this.gameObject.GetComponent<Animator>().Play("PlanetList2");
                isActive = false;
            }
            else
            {
                this.gameObject.GetComponent<Animator>().Play("PlanetList");
                isActive = true;
            }
            
        }
    }
}
