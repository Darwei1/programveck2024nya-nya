// Import necessary libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Define a class named DialogueManager that inherits from MonoBehaviour
public class DialogueManager : MonoBehaviour // Skapad av vincent
{
    // Public variables that can be accessed from the Unity Editor
    public TextMeshProUGUI textComponent; // Text component for displaying dialogue
    public string[] lines; // Array of strings representing individual lines of dialogue
    public float textSpeed; // Speed at which text is displayed

<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> cceec15c584b12f3f534395b4120d8ec9a4b30a8
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

<<<<<<< HEAD
=======
    private int index; // Index to keep track of the current line of dialogue

    // Start is called before the first frame update
>>>>>>> d5135f9eef5a9f4304f46a30aa556eec52208fbe
=======
>>>>>>> cceec15c584b12f3f534395b4120d8ec9a4b30a8
    void Start()
    {
        textComponent.text = string.Empty; // Initialize the text component with an empty string
    }

    // Update is called once per frame
    public void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Check if the displayed text matches the current line
            if (textComponent.text == lines[index])
            {
                NextLine(); // Move to the next line of dialogue
            }
            else
            {
<<<<<<< HEAD
<<<<<<< HEAD

=======
                StopAllCoroutines(); // Stop any ongoing text animations
                textComponent.text = lines[index]; // Display the entire line instantly
                Destroy(this.gameObject); // Destroy the DialogueManager (not typical, usually deactivated)
>>>>>>> d5135f9eef5a9f4304f46a30aa556eec52208fbe
=======
                StopAllCoroutines(); // Stop any ongoing text animations
                textComponent.text = lines[index]; // Display the entire line instantly
                Destroy(this.gameObject); // Destroy the DialogueManager (not typical, usually deactivated)
>>>>>>> cceec15c584b12f3f534395b4120d8ec9a4b30a8
            }
        }
    }

    // Function to move to the next line of dialogue
    public void NextLine()
    {
        // Check if there are more lines of dialogue
        if (index < lines.Length - 1)
        {
            index++; // Move to the next line
            textComponent.text = string.Empty; // Clear the text component
            StartCoroutine(TypeLine()); // Start animating the next line
        }
        else
        {
            gameObject.SetActive(false); // Disable the entire dialogue manager when all lines are displayed
        }
    }

    // Function to start the dialogue
    public void StartDialogue()
    {
        index = 0; // Initialize the index to the first line
        gameObject.SetActive(true); // Activate the dialogue manager
    }

    // Coroutine for animating the text one character at a time
    public IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c; // Add one character at a time
            yield return new WaitForSeconds(textSpeed); // Wait for the specified time before the next character
        }
    }
}
