using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsManager : MonoBehaviour
{
    public GameObject TuberTitle;
    bool ControlButtonPressed;

    void Start()
    {
        TuberTitle = GameObject.Find("TUBER_Title");
    }

    public void ControlsButtonPressed()
    {
        TuberTitle.gameObject.SetActive(false);
    }

    void Update()
    {

    }
}
