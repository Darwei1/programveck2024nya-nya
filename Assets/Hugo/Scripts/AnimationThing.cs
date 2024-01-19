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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && isActive == false)
        {
            this.gameObject.GetComponent<Animator>().Play("PlanetList");
            isActive = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && isActive == true)
        {
            this.gameObject.GetComponent<Animator>().Play("PlanetList2");
            isActive = false;
        }
    }
}
