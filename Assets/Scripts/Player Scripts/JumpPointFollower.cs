using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPointFollower : MonoBehaviour
{
    public Transform PlayerObject;          
    public Transform JumpObject;            
    public Quaternion PlayerObjectRotation; 
    public Vector3 JumpPoint;               


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.localRotation = Quaternion.Slerp(PlayerObject.localRotation, PlayerObject.localRotation, 0.2f*Time.deltaTime);    

        JumpPoint = new Vector3(PlayerObject.localPosition.x, PlayerObject.localPosition.y, PlayerObject.localPosition.z); 

        JumpObject.position = JumpPoint;

    }
}