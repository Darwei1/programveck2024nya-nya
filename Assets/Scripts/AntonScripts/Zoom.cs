using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private Camera magnifyCamera;
    private float MGWidth = Screen.width / 5f, MGHeight = Screen.width / 5f; // Magnify glass width and height
    private Vector3 mousePos;

   

    void Start()
    {
        createMagnifyGlass();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleZoom();
        }

        if (magnifyCamera != null && magnifyCamera.enabled)
        {
            //Set the camera's pixelRect and camera position at mouse position
            magnifyCamera.pixelRect = new Rect(Input.mousePosition.x - MGWidth / 2.0f, Input.mousePosition.y - MGHeight / 2.0f, MGWidth, MGHeight);
            mousePos = getWorldPosition(Input.mousePosition);
            magnifyCamera.transform.position = mousePos;
            mousePos.z = 0;
        }
    }

    //Method creates the magnifying glass
    private void createMagnifyGlass()
    {
        GameObject cameraObject = new GameObject("MagnifyCamera");
        magnifyCamera = cameraObject.AddComponent<Camera>();
        magnifyCamera.enabled = false;

       

        if (Camera.main.orthographic)
        {
            magnifyCamera.orthographic = true;
            magnifyCamera.orthographicSize = Camera.main.orthographicSize / 5.0f;
        }
        else
        {
            magnifyCamera.orthographic = false;
            magnifyCamera.fieldOfView = Camera.main.fieldOfView / 10.0f;
        }
    }

    private void ToggleZoom()
    {
        if (magnifyCamera != null)
        {
            magnifyCamera.enabled = !magnifyCamera.enabled;
        }
    }


    //Method calculates world's point from screen point as per camera's projection type
    public Vector3 getWorldPosition(Vector3 screenPos)
    {
        Vector3 worldPos;
        if (Camera.main.orthographic)
        {
            worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            worldPos.z = Camera.main.transform.position.z;
        }
        else
        {
            worldPos = Camera.main.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, Camera.main.transform.position.z));
            worldPos.x *= -1;
            worldPos.y *= -1;
        }
        return worldPos;
    }

}
