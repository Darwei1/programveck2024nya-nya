// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define a class named Permit that extends GameManager
public class Permit : GameManager // skapad av vincent
{
    // Reference to the permit prefab to be spawned
    public GameObject permit_Prefab;

    // Update is called once per frame
    public void Update()
    {
        // Check if the spawn permit is true
        if (spawnPermit == true)
        {
            SpawnPermitOnCharacterSpawn(); // Call function to spawn a permit
            resetPermitSpawnable(); // Reset the spawn permit
        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        // Instantiate a permit prefab at the specified position and rotation when the game starts
        spawnableObj = Instantiate(permit_Prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Function to spawn a permit when a character is spawned
    public void SpawnPermitOnCharacterSpawn()
    {
        // Instantiate a permit prefab at the specified position and rotation
        spawnableObj = Instantiate(permit_Prefab, new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("Successfully spawned a permit");
    }
}
