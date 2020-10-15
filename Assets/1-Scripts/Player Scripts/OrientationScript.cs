using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationScript : MonoBehaviour
{
    public GameObject Player;
    public float rotTime;
    Vector3 PlayerCenter;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerCenter = Player.gameObject.transform.position;
        rotTime = rotTime + Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit HitInfo;

      
        Physics.Raycast(transform.position, -transform.up, out HitInfo, Mathf.Infinity);         //Actual raycast

        Debug.DrawRay(transform.position, -transform.up * Mathf.Infinity, Color.red);           //Raycast debug so we can visualize it

        //transform.localRotation = HitInfo.transform.localRotation;

        transform.localRotation = Quaternion.Slerp(transform.localRotation, HitInfo.transform.localRotation, rotTime);
        
    }
}
