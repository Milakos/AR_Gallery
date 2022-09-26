using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamegame : MonoBehaviour
{   
    private int currentScene = 0;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }
    public void OnApplicationQuit() 
    {
        Application.Quit();    
    }
}
