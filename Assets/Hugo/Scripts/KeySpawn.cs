using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject objectToSpawn;

    public GameObject pref;
    public bool spawn;// its true
    // Start is called before the first frame update
    private void Start()
    {
        
    }
     void Update()
    {
        pref = GameObject.FindGameObjectWithTag("guest");
        
        
    }
    public void OnButtonPress()
    {
        if (pref != null)
        {
            spawn = true;
        }
        if (spawn == true)
        {
            Instantiate(objectToSpawn, new Vector3(3, -3, 0), Quaternion.Euler(0, 0, -90));
            spawn = false;
        }

    }
    
}
