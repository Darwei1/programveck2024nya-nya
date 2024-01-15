using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame(){ //Loading Mainscene when calling for this function
        SceneManager.LoadScene("MainScene");
        print("SceneLoad");
    }
    public void Settings(){ 
        
    }
    public void Credits(){
        
    }
    public void Exit(){
        Application.Quit(0);
    }
}
