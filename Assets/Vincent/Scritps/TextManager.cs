// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// Define a class named TextManager that inherits from MonoBehaviour
public class TextManager : MonoBehaviour // skapad av vincent
{
    // Text components for the alien and the player
    public TextMeshProUGUI Alien;
    public TextMeshProUGUI You;

    // Arrays of strings for different conversation segments
    [Header("Greetings")]
    public string[] greats;
    public string[] greatsYou;

    [Header("Small talk")]
    public string[] alienTalk;
    public string[] youTalk;

    [Header("Goodbyes")]
    public string[] alienLeaving;
    public string[] youLeaving;

    // Buttons used in the conversation
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;

    // Start is called before the first frame update
    private void Start()
    {
        // Initialize the conversation with a random greeting
        Alien.text = greats[Random.Range(0, 3)];
        You.text = greatsYou[Random.Range(0, 3)];
    }

    // Update is called once per frame
    private void Update()
    {
        // No specific actions in the Update function in this script
    }

    // Function triggered when the first button is pressed
    public void onButtonPress()
    {
        // Set new random greetings for both the alien and the player
        Alien.text = greats[Random.Range(0, 3)];
        You.text = greatsYou[Random.Range(0, 3)];

        // Manage button visibility
        button1.SetActive(false);
        button2.SetActive(true);
    }

    // Function triggered when the second button is pressed
    public void onButtonPress1()
    {
        // Set new random small talk messages for both the alien and the player
        Alien.text = alienTalk[Random.Range(0, 3)];
        You.text = youTalk[Random.Range(0, 3)];

        // Manage button visibility
        button2.SetActive(false);
        button3.SetActive(true);
    }

    // Function triggered when the third button is pressed
    public void onButtonPress2()
    {
        // Set new random goodbye messages for both the alien and the player
        Alien.text = alienLeaving[Random.Range(0, 3)];
        You.text = youLeaving[Random.Range(0, 3)];
    }
}
