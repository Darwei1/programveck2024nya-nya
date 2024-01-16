using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pointsystem : PassportMatching //gjort av Jack
{
    public Text moneyText;
    private int playerMoney;

    void Start()
    {
        LoadPlayerMoney();

        MerPengar(100);

        MindrePengar(30);

        UpdateUI();
    }

    public void MerPengar(int amount) //if choice right then get money and display money value
    {
        if (choice == true)
        {
            playerMoney += amount;

            print("Added " + amount + " to money. Current money: " + playerMoney);

            SavePlayerMoney();
        }

    }

    public void MindrePengar(int amount) // if wrong choice then no money
    {
        if (choice == false)
        {
            playerMoney -= amount;
            print("Subtracted " + amount + " from money. Current money: " + playerMoney);

            SavePlayerMoney();
        }

    }

    private void SavePlayerMoney() // save the value of the current money amount 
    {
        PlayerPrefs.SetInt("PlayerMoney", playerMoney);

        PlayerPrefs.Save();
    }

    private void LoadPlayerMoney() //load the player money amount
    {
        playerMoney = PlayerPrefs.GetInt("PlayerMoney", 0);
    }

    private void UpdateUI() //update the UI to show the money amount
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: " + playerMoney;
        }
    }



}
