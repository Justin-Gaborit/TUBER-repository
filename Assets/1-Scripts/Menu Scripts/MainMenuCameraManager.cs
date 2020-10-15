using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCameraManager : MonoBehaviour
{
    public float CameraMoveSpeed;

    private void Start()
    {
        CameraMoveSpeed = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * CameraMoveSpeed * Time.deltaTime;
    }
}
