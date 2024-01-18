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
    public float rentPoints; 
    float maxRentPoints = 90f;
    public float foodPoints; 
    float maxFoodPoints = 90f;
    public float heatPoints; 
    float maxHeatPoints = 90f;
    void Start()
    {
        // set points to max points
        rentPoints = maxRentPoints;
        foodPoints = maxFoodPoints;
        heatPoints = maxHeatPoints;
        StatsRandomReducer();
    }
    void Update()
    {
        // Make sure points do not go over maxPoints
        if (rentPoints > maxRentPoints) rentPoints = maxRentPoints;
        if (foodPoints > maxFoodPoints) foodPoints = maxFoodPoints;
        if (heatPoints > maxHeatPoints) heatPoints = maxHeatPoints;

        StatBarFiller();
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

    public void Damage(float damagePoints) // mostly for debug 
    {
        rentPoints -= damagePoints;
        foodPoints -= damagePoints;
        heatPoints -= damagePoints;  
    }
    public void Heal(float statPoints) // ^^
    {
        rentPoints += statPoints;
        foodPoints += statPoints;
        heatPoints += statPoints;
        print(rentPoints);
        print(foodPoints);
        print(heatPoints);
    }
    
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

    #region all the functions for these bars
    public void AddRentFunction(float statPoints){
        rentPoints += statPoints;
    }
    public void RemoveRentFunction(float statPoints){
        if (rentPoints > 0){
            rentPoints -= statPoints;
        }
    }

    public void AddFoodFunction(float statPoints){
        foodPoints += statPoints;
    }
    public void RemoveFoodFunction(float statPoints){
        if (foodPoints > 0){
            foodPoints -= statPoints;
        }
    }

    public void AddHeatFunction(float statPoints){
        heatPoints += statPoints;
    }
    public void RemoveHeatFunction(float statPoints){
        if (heatPoints > 0){
            heatPoints -= statPoints;
        }
    }
    #endregion
}
