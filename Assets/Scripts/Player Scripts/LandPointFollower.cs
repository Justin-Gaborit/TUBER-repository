using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandPointFollower : MonoBehaviour
{
    public Transform PlayerObject;
    public Transform LandObject;
    public Vector3 LandPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LandPoint = new Vector3(PlayerObject.position.x, LandObject.position.y, PlayerObject.position.z);
        LandObject.position = LandPoint;
    }
}
