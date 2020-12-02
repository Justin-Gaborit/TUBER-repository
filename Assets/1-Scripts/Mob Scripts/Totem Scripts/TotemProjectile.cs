using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemProjectile : MonoBehaviour
{
    public int movespeed;

    // Start is called before the first frame update
    void Start()
    {
        movespeed = 90;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= transform.forward * movespeed * Time.deltaTime;
    }
}
