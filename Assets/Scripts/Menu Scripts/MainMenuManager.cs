using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public Animator mainmenumanager;
    int currentoption = 0;

    // Update is called once per frame
    void Start()
    {
        mainmenumanager = GetComponent<Animator>();                    //Gets ahold of animator
        mainmenumanager.SetBool("start_to_controls", true);
        currentoption = 1;
    }

    void Update()
    {
        if (currentoption == 1 && Input.GetKey(KeyCode.DownArrow))
        {
            mainmenumanager.SetBool("controls_to_exit", true);
            currentoption = 2;
            Input.ResetInputAxes();
        }
    }
}
