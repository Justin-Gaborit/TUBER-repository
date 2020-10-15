using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float _MoveSpeed;     // How fast the player moves from left to right
    public float _JumpSpeed;     // How much force is applied to the character when they jump
    public float _RunSpeed;      // How fast the player moves forward through TUBE WORLD
    public float _Gravity;       // Downward force applied to the player
    public float _MaxSpeed;      // Maximum speed that the player can move at (left or right)
    public float _CurrentSpeed;  // Players Current speed
    public bool _Grounded;       // Returns if the player is on the ground or not
    public bool _Test;
    public Rigidbody _PlayerRB;  // The players rigidbody

    public GameObject JumpPoint; // Gets the JumpPoint Object
    public GameObject LandPoint; // Gets the LandPoint Object

    void Start()
    {
        _PlayerRB = GetComponent<Rigidbody>();
        _Grounded = true;
        _Test = true;
    }

    private void FixedUpdate()
    {
        //Grond Detection Raycast
        RaycastHit HitInfo;                                                     //Returns raycasts hit value
        Physics.Raycast(transform.position, -transform.up, out HitInfo, 4);     //Creates physics raycast
        Debug.DrawRay(transform.position, -transform.up * 4, Color.blue);       //Creates the debug ray so we can see what our raycast looks like

        //Jump Height Raycast
        RaycastHit JumpInfo;                                                    //Returns jump height raycasts hit value
        Physics.Raycast(transform.position, -transform.up, out JumpInfo, 9);    //Creates jump height physics raycast
        Debug.DrawRay(transform.position, -transform.up * 9, Color.yellow);    //Creates the debug ray so we can see what our jump height raycast looks like

        if (HitInfo.collider == false)
        {
            _Grounded = false;
        }
        if (HitInfo.collider == true)
        {
            _Grounded = true;
        }

        // Jumping
        if (Input.GetKeyDown("space") && _Grounded == true)
        {
            _PlayerRB.velocity = transform.up * _JumpSpeed * Time.deltaTime;
            _Test = false;
            Debug.Log("Jump Worked");
        }

        // Gravity transform
        _PlayerRB.AddForce(-transform.up * _Gravity * Time.deltaTime);

        // Endless running transform
        transform.position += transform.forward * _RunSpeed * Time.deltaTime;

        //Gets value for _CurrentSpeed
        _CurrentSpeed = _PlayerRB.velocity.magnitude;

        //Clamps velocity to stop player from moving over _MaxSpeed
        _PlayerRB.velocity = Vector3.ClampMagnitude(_PlayerRB.velocity, _MaxSpeed);
    }

    /* Void Update must be used for movement instead of 
    Void FixedUpdate as it was causing player sliding problems */
    void Update()
    {
        // Move Right (Grounded)
        if (Input.GetKey("right") && _PlayerRB.velocity.magnitude <= _MaxSpeed)
        {
            _PlayerRB.velocity += transform.right * _MoveSpeed;
        }
        else if (Input.GetKeyUp("right"))
        {
            _PlayerRB.velocity = Vector3.ClampMagnitude(_PlayerRB.velocity, 0);
        }

        // Move Left (Grounded)
        if (Input.GetKey("left") && _PlayerRB.velocity.magnitude <= _MaxSpeed)
        {
            _PlayerRB.velocity -= transform.right * _MoveSpeed;
        }
        else if (Input.GetKeyUp("left"))
        {
            _PlayerRB.velocity = Vector3.ClampMagnitude(_PlayerRB.velocity, 0);
        }
    }
}