using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathSceneChange : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("SampleScene 1");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Application.Quit();
        }
    }
}
