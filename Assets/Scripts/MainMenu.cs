using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        //SceneManager.LoadScene("Level_0")
    }

    // Update is called once per frame
    public void QuitGame()
    {
       Application.Quit(); 
    }

    public void GoToSeetingsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToGameMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
