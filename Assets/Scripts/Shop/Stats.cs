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
    float rentPoints, maxRentPoints = 90;
    float foodPoints, maxFoodPoints = 90;
    float heatPoints, maxHeatPoints = 90;
    void Start()
    {
        // set points to max points
        rentPoints = maxRentPoints;
        foodPoints = maxFoodPoints;
        heatPoints = maxHeatPoints;
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

    public void Damage(float damagePoints)
    {
        if (rentPoints > 0 || foodPoints > 0 || heatPoints > 0)
            rentPoints -= damagePoints;
            foodPoints -= damagePoints;
            heatPoints -= damagePoints;
    }
    public void Heal(float statPoints)
    {
        if (rentPoints < 0 || foodPoints < 0 || heatPoints < 0)
            rentPoints += statPoints;
            foodPoints += statPoints;
            heatPoints += statPoints;
    }
}
