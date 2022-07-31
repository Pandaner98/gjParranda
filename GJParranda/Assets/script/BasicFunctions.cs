using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicFunctions : MonoBehaviour
{
    
    public void SceneChanger()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MenuReturn()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
