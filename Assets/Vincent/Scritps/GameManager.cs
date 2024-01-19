// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Define a class named GameManager that inherits from MonoBehaviour 
public class GameManager : MonoBehaviour // skapad av vincent
{
    // Boolean variables for spawn manager control (marked as static for global access)
    static public bool yes;
    static public bool no;

    // Variables for controlling the maximum number of characters and a randomly set maximum
    public int maxAmountOfCharacters;
    public int randomMaxAmountOfCharacters;

    // Static variable controlling whether spawning is permitted globally
    static public bool spawnPermit = false;

    // GameObjects for the spawned character and the object that can be spawned
    public GameObject spawnedCharacter;
    public GameObject spawnableObj;

    // Function to reset the spawn permit
    public void resetPermitSpawnable()
    {
        // Check if the spawn permit is true
        if (spawnPermit == true)
        {
            spawnPermit = false; // Reset the spawn permit
            destroyPermit(); // Destroy the permit object
        }
    }

    // Function to destroy the previously spawned character
    public void DestroyPreviousCharacter()
    {
        // Check if there is a spawned character
        if (spawnedCharacter != null)
        {
            Destroy(spawnedCharacter); // Destroy the previously spawned character
            resetPermitSpawnable(); // Reset the spawn permit
        }
    }

    // Function to destroy the permit object
    public void destroyPermit()
    {
        // Check if there is a permit object
        if (spawnableObj != null)
        {
            Destroy(spawnableObj); // Destroy the permit object
            Debug.Log("Successfully destroyed a permit");
        }
    }
}
