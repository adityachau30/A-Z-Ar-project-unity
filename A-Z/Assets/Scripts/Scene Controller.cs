using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    
    public void MainMenu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void ARScene()
    {
        SceneManager.LoadScene("AR");
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

