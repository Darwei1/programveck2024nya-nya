using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointsystem : MonoBehaviour
{

    public bool choice;

    public int Money =  0;

    void Start()
    {
      
    }

    void Update()
    {
        if (choice == true) // om man g�r r�tt val f�r man 100 pengar
        {
            print("Point added");
            Money += 100;
        }
        else
        {
            print("No point added");
            //m�jlighet f�r "d�lig preformance" (man f�r sparken efter x antal fel)
        }
    }
}
