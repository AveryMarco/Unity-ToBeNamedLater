using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Playing the Starting Scene using the build/ Scene index in the build settings
    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Closing/ Quitting the Game
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
