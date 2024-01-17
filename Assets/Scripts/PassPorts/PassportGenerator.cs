using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.UI;

public class PassportGenerator : MonoBehaviour // Diyor
{
    public GameObject currentPassport;


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
    List<string> socialStatuses = new List<string>{
        "Actively Criminal", 
        "Legal", 
        "Former gang criminal",
    };
    List<string> incomes = new List<string>{
        "Rich",
        "Working Class",
        "Homeless",
        "Middle Class",
        "Lower Class",
    };
     List<string> sexes = new List<string>{
        "Female",
        "Male",
        "Non binary"
     };
    // Random info about ppl
    public int value;
    
    // variables for textmeshes in passports
    #region Textmesh
    public TextMesh nameText;
    public TextMesh dateOfBirthText;
    public TextMesh sexText;
    public TextMesh planetText;
    public TextMesh socialStatusText;
    public TextMesh incomeText;
    public TextMesh expirationDateText;
    #endregion

	const int baseFakeValue = 7; // how big chance for the Planet in the passport to be a real planet
    public int dobYear;
    public int dobMonth;
    public int dobDay;
    public bool isLetterValid = true;


    private void FixedUpdate()
    {
        if (currentPassport == null)
        {
            currentPassport = GameObject.FindGameObjectWithTag("A");
        }
        else if(nameText == null)
        {
            ReadPassport();
        }
    }

    void ReadPassport()
    {
        nameText = currentPassport.transform.GetChild(0).GetComponent<TextMesh>();
        dateOfBirthText = currentPassport.transform.GetChild(1).GetComponent<TextMesh>();
        sexText = currentPassport.transform.GetChild(2).GetComponent<TextMesh>();
        planetText = currentPassport.transform.GetChild(3).GetComponent<TextMesh>();
        socialStatusText = currentPassport.transform.GetChild(4).GetComponent<TextMesh>();
        incomeText = currentPassport.transform.GetChild(5).GetComponent<TextMesh>();
        expirationDateText = currentPassport.transform.GetChild(6).GetComponent<TextMesh>();
    }


	public void Generate()
	{
        // Pick a random thing from every list
		string firstName = PickRandomFromList(firstNames) + " ";
		string surname = PickRandomFromList(surNames);
		string planet = PickRandomFromList(planets);
        string socialStatus = PickRandomFromList(socialStatuses);
        string income = PickRandomFromList(incomes);
        string sex = PickRandomFromList(sexes);

		value = Random.Range(1, 10);

        // Random Birth Date
        dobYear = Random.Range(1000, 2500);
        dobMonth = Random.Range(1, 12);
        dobDay = Random.Range(1, 28);

        int expDateYear = dobYear + Random.Range(20, 500);

        string dobValue = dobYear + "-" + dobMonth + "-" + dobDay;

		//generate incorrect letter
		if (value >= baseFakeValue)
		{
			isLetterValid = false;
				planet = PickRandomFromList(fakePlanets) + " is FAKE";
		}

        // Sets the values for every thing in the pass
		string passName = firstName + surname;
        string passSex = sex;
        string passPlanet = planet;
        string passSStatus = socialStatus;
        string passIncome = income;
        string passEXPDate = expDateYear.ToString() + "-" + dobMonth + "-" + dobDay;

        // Sets the text to following values
        nameText.text = passName;
        sexText.text = sex;
        dateOfBirthText.text = dobValue;
        planetText.text = passPlanet;
        socialStatusText.text = passSStatus;
        incomeText.text = passIncome;
        expirationDateText.text = passEXPDate;

        print(firstName);
        print(planet);
        print(surname);
	}

    //takes a List<string> as input and returns a randomly selected string from the list.
	string PickRandomFromList(List<string> list)
	{
		int index = Mathf.RoundToInt(Random.Range(0, list.Count));

		return list[index];
	}
}