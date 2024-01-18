using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                Destroy(this.gameObject);
                
            }
        }
    }

    public void NextLine()
    {
        if (index < lines.Length - 1)
        {

            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void StartDialogue()
    {
        
        index = 0;
        StartCoroutine(TypeLine());
        gameObject.SetActive(true);
    }

    public IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
