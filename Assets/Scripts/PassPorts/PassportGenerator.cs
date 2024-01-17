using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class PassportGenerator : MonoBehaviour
{
    List<string> firstNames = new List<string> {
    "Zarnak",
    "Xylara",
    "Quorin",
    "Vylis",
    "Nexara",
    "Zephyrion",
    "Lyrion",
    "Dravax",
    "Synthara",
    "Gralnak"};
    List<string> surNames = new List<string> {
    "Vortis",
    "Xandros",
    "Kyralis",
    "Zenthos",
    "Vorlonis",
    "Thalrak",
    "Grythonix",
    "Sylaris",
    "Quixar",
    "Xyloxis"};
    List<string> planets = new List<string> {
    "Mercury",
    "Venus",
    "Earth",
    "Mars",
    "Jupiter",
    "Saturn",
    "Uranus",
    "Neptune",
    "Pluto",
    "Ceres"
    };
    List<string> fakePlanets = new List<string> {
    "Mercurion",
    "Venusia",
    "Eartharis",
    "Marsis",
    "Jupiteron",
    "Saturna",
    "Uranix",
    "Neptoria",
    "Plutonix",
    "Cerion"
    };
    List<string> socialStatus = new List<string>{
        "Actively Criminal", 
        "Legal", 
        "Former gang criminal",
    };
    // Random info about ppl
	public float z = 0;
    public int value;
    public TextMesh text;
	const int baseFakeValue = 7;

	public void Generate()
	{
		string firstName = PickRandomFromList(firstNames) + " ";
		string surname = PickRandomFromList(surNames);
		string planet = PickRandomFromList(planets);

		bool isLetterValid = true;

		value = Random.Range(1, 10);
        print(value);

		//generate incorrect letter
		if (value >= baseFakeValue)
		{
			isLetterValid = false;
				planet = PickRandomFromList(fakePlanets) + " is FAKE";
		}

		string address = firstName + surname + "\n" + planet;

		z+= .2f;
		if (z > 8.5)
			z = 0;

        print(firstName);
        print(planet);
        print(surname);

        text.text = address;
	}
    //takes a List<string> as input and returns a randomly selected string from the list.
	string PickRandomFromList(List<string> list)
	{
		int index = Mathf.RoundToInt(Random.Range(0, list.Count));

		return list[index];
	}
}