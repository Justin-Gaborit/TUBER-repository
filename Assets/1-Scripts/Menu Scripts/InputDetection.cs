using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetection : MonoBehaviour
{
    public GameObject MouseCursor;

    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))    
        {
            MouseCursor.SetActive(false);
        }
    }
}
