using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag2 : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;


   

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            //Move object and set the center of object where mouse clicked
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {

        dragging = false;//Stop dragging
    }
}
