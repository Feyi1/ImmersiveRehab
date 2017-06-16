using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 

public class Menu : MonoBehaviour
{
    public void NewGameLoad(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
        //Application.LoadLevel(sceneonLoad);

    }
       
    public void ExitGame()
    {
        Application.Quit();
    }
}
