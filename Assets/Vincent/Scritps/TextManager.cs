using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TextManager : MonoBehaviour
{

    public TextMeshProUGUI Alien;
    public TextMeshProUGUI You;

    // the greeting part
    [Header("Greetings")]
    public string[] greats;
    public string[] greatsYou;

    // the greeting part
    [Header("small talk")]
    public string[] alienTalk;
    public string[] youTalk;

    // the greeting part
    [Header("goodbyes")]
    public string[] alienLeaving;
    public string[] youLeaving;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;



    private void Start()
    {
        Alien.text = greats[Random.Range(0, 3)];
        You.text = greatsYou[Random.Range(0, 3)];
    }
    private void Update()
    {

        

    }

    public void onButtonPress()
    {

        Alien.text = greats[Random.Range(0, 3)];
        You.text = greatsYou[Random.Range(0, 3)];


        button1.SetActive(false);
        button2.SetActive(true);

    }
    public void onButtonPress1()
    {

        Alien.text = alienTalk[Random.Range(0, 3)];
        You.text = youTalk[Random.Range(0, 3)];

        button2.SetActive(false);
        button3.SetActive(true);
    }
    public void onButtonPress2()
    {

        Alien.text = alienLeaving[Random.Range(0, 3)];
        You.text = youLeaving[Random.Range(0, 3)];
        
    }

}
