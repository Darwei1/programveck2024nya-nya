using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleGenerator : MonoBehaviour
{
    // Start is called before the first frame update
  


    List<string> planetRules = new List<string> {
    "NO VENUSIANS",
    "NO MARSIANS",
    "NO MERCURIANS",
    "NO EARTHLINGS",
    "NO JUPITERANS",
    "NO SATURNIANS",
    "NO URANIANS",
    "NO NEPTUNIANS",
    "NO PLUTONIANS",
    "NO CERESIANS"};
    List<string> surNamesRules = new List<string> {
    "NO Vortis",
    "NO Xandros",
    "NO Kyralis",
    "NO Zenthos",
    "NO Vorlonis",
    "NO Thalrak",
    "NO Grythonix",
    "NO Sylaris",
    "NO Quixar",
    "NO Xyloxis"};
   
    public int value;

    #region Textmesh
    public TextMesh planetRuleText;
    public TextMesh surnameRuleText;
    
    #endregion

    const int baseFakeValue = 7;
    
    public bool isLetterValid = true;

    private void Start()
    {
        Generate();
    }





    public void Generate()
    {
        string firstName = PickRandomFromList(planetRules) + " ";
        string surname = PickRandomFromList(surNamesRules);
        
        value = Random.Range(1, 10);
        
        

        //generate incorrect letter
       

        string planetRule = firstName;
        string surnameRule = surname;
        

        planetRuleText.text = firstName;
        surnameRuleText.text = surname;
        

        print(firstName);
        
        print(surname);
    }
    //takes a List<string> as input and returns a randomly selected string from the list.
    string PickRandomFromList(List<string> list)
    {
        int index = Mathf.RoundToInt(Random.Range(0, list.Count));

        return list[index];
    }

}
