using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    #region rentArrays // Arrays for imageBars
    public Image[] rentRent;
    public Image[] foodRent;
    public Image[] heatRent;
    #endregion
    public int rentPoints; 
    int maxRentPoints = 90;
    public int foodPoints; 
    int maxFoodPoints = 90;
    public int heatPoints; 
    int maxHeatPoints = 90;
    public bool alive;
    public Pointsystem money;

    void Start()
    {
        StatsRandomReducer(); // Everytime this script activates it randomly decreases all of the stats

        LoadPlayerMoney();

        // set points to max points 
        /*
        rentPoints = maxRentPoints;
        foodPoints = maxFoodPoints;
        heatPoints = maxHeatPoints;
        */
        money = GetComponent<Pointsystem>(); // for money from this script
    }
    void Update()
    {
        // Make sure points do not go over maxPoints
        if (rentPoints > maxRentPoints) rentPoints = maxRentPoints;
        if (foodPoints > maxFoodPoints) foodPoints = maxFoodPoints;
        if (heatPoints > maxHeatPoints) heatPoints = maxHeatPoints;

        StatBarFiller();

        if (rentPoints >= 0 || foodPoints >= 0 || heatPoints >= 0)
        {
            alive = true;
        }else {
            alive = false;
        }
        if (alive == false)
        {
            print("gg u lost");
        }
    }

    private void LoadPlayerMoney() //load the player money amount
    {
        rentPoints = PlayerPrefs.GetInt("Rent", 0);
        foodPoints = PlayerPrefs.GetInt("Food", 0);
        heatPoints = PlayerPrefs.GetInt("Heat", 0);
    }

    // Method to fill the UI bars based on the current stat points
    void StatBarFiller()
    {
        // go through rent related images and enable/disable based on points
        for (int i = 0; i < rentRent.Length; i++)
        {
            rentRent[i].enabled = !DisplayRentPoints(rentPoints, i);
        }
        for (int i = 0; i < foodRent.Length; i++)
        {
            foodRent[i].enabled = !DisplayRentPoints(foodPoints, i);
        }
        for (int i = 0; i < heatRent.Length; i++)
        {
            heatRent[i].enabled = !DisplayRentPoints(heatPoints, i);
        }
    }

     // Method to check whether a point should be displayed or not
    bool DisplayRentPoints(float _health, int pointNumber)
    {
        // Check if the point number times 10 is greater than or equal to the health
        return ((pointNumber * 10) >= _health);
    }

    #region Debug stuff >_<
    public void Damage(int damagePoints) // mostly for debug 
    {
        rentPoints -= damagePoints;
        foodPoints -= damagePoints;
        heatPoints -= damagePoints;  
    }
    public void Heal(int statPoints) // ^^
    {
        rentPoints += statPoints;
        foodPoints += statPoints;
        heatPoints += statPoints;
        print(rentPoints);
        print(foodPoints);
        print(heatPoints);
    }
    #endregion
    
    // It basically takes a random number 1-3 and multiplies it with 10 so its easier for the statBars to decrease bla bla
    public void StatsRandomReducer(){
        int randomRentDecrease = Random.Range(1, 3);
        int randomFoodDecrease = Random.Range(1, 3);
        int randomHeatDecrease = Random.Range(1, 3);

        rentPoints -= randomRentDecrease * 10;
        foodPoints -= randomFoodDecrease * 10;
        heatPoints -= randomHeatDecrease * 10;

        print(randomRentDecrease + " " + randomFoodDecrease + " " + randomHeatDecrease);
    }

    // Basically i save all the values and change scene
    public void NextDay(){
        PlayerPrefs.SetInt("Rent", rentPoints);
        PlayerPrefs.SetInt("Food", foodPoints);
        PlayerPrefs.SetInt("Heat", heatPoints);
        PlayerPrefs.SetInt("PlayerMoney", money.playerMoney);
        
        PlayerPrefs.Save();
        print("Saved!");
        money.MerPengar(20);
    }

    #region all the functions for these bars
    public void AddRentFunction(int statPoints){
        if (money.playerMoney >= 5 && rentPoints < 90){
            rentPoints += statPoints;
            money.playerMoney -= 5;
        }
    }
    public void RemoveRentFunction(int statPoints){
        if (rentPoints > 0){
            rentPoints -= statPoints;
        }
    }

    public void AddFoodFunction(int statPoints){
        if (money.playerMoney >= 5 && foodPoints < 90){
            foodPoints += statPoints;
            money.playerMoney -= 5;
        }
    }
    public void RemoveFoodFunction(int statPoints){
        if (foodPoints > 0){
            foodPoints -= statPoints;
        }
    }

    public void AddHeatFunction(int statPoints){
        if (money.playerMoney >= 5 && heatPoints < 90){
           heatPoints += statPoints; 
           money.playerMoney -= 5;
        }
    }
    public void RemoveHeatFunction(int statPoints){
        if (heatPoints > 0){
            heatPoints -= statPoints;
        }
    }
    #endregion
}
