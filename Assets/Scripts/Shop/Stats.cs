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
    float points, maxPoints = 90;
    void Start()
    {
        // set points to max points
        points = maxPoints;
    }
    void Update()
    {
        // Make sure points do not go over maxPoints
        if (points > maxPoints) points = maxPoints;
        StatBarFiller();
    }

    // Method to fill the UI bars based on the current stat points
    void StatBarFiller()
    {
        // go through rent related images and enable/disable based on points
        for (int i = 0; i < rentRent.Length; i++)
        {
            rentRent[i].enabled = !DisplayRentPoints(points, i);
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
        if (points > 0)
            points -= damagePoints;
    }
    public void Heal(float statPoints)
    {
        if (points < maxPoints)
            points += statPoints;
    }
}
