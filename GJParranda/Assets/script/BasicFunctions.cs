using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicFunctions : MonoBehaviour
{

    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject LosePanel;
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

    public void Win()
    {
        WinPanel.SetActive(true);
    }
    public void Lose()
    {
        LosePanel.SetActive(true);
    }
}
