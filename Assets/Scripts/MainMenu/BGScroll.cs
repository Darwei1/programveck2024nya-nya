using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour // Diyor. Gjorde s� att bakgrunden s�g ut som om att den var o�ndligt l�ng genom att duplicera bakgrunden och flytta tillbaka till startPos n�r bakgrunden har n�tt en viss punkt.
{
    public bool doneAnim;
    public GameObject targetObject;
    public float speed = 4f;
    private Vector3 StartPosition;
    [SerializeField] private CanvasGroup myUIGroup;
    void Start()
    {
        targetObject.SetActive(false);
    }


    void Update()
    {
        if (transform.position.y >= -7.7f)
        {
            transform.Translate(Vector3.down*speed*Time.deltaTime);
        } else
        {
            targetObject.SetActive(true);
            doneAnim = true;
        }

        if (myUIGroup.alpha < 1 && doneAnim)
        {
            myUIGroup.alpha += 0.009f;
        }
    }
}
