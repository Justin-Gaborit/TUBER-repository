using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuManager : MonoBehaviour
{
    public void RunButtonPressed()
    {
        SceneManager.LoadScene("RunScene");
    }

    public void MainMenuButtonPressed()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
