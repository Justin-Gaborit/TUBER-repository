using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerV2 : MonoBehaviour
{
    public Rigidbody _PlayerRB;     // The players rigidbody

    public float _Gravity;          // Downward force applied to the player
    public float _RunSpeed;
    public float _LRSpeed;          // How fast the player moves from left to right
    public float _LRMaxSpeed;
    public float _JumpSpeed;        // How fast the player moves upwards when jumping

    public bool _Grounded;          // Returns if the player is on the ground or not
    public bool _JumpHeightMet;
    public bool _IsJumping;

    void Start()
    {
        _PlayerRB = GetComponent<Rigidbody>();      //Fetches the rigidbody attached to the player
        _Grounded = true;                           //Player is grounded by default
        _JumpHeightMet = false;
        _LRMaxSpeed = _LRSpeed;
        _IsJumping = false;
        _RunSpeed = 40;
    }

    void Update()
    {
        if (Input.GetKey("right") && _PlayerRB.velocity.magnitude <= _LRMaxSpeed && _Grounded == true)
        {
            transform.Translate(Vector3.right * _LRSpeed * Time.deltaTime);
            //_PlayerRB.velocity = transform.right * _LRSpeed;
        }
        else if (Input.GetKeyUp("right") && _Grounded == true)
        {
            _PlayerRB.velocity = Vector3.zero;
        }

        if (Input.GetKey("left") && _PlayerRB.velocity.magnitude <= _LRMaxSpeed && _Grounded == true)
        {
            transform.Translate(-Vector3.right * _LRSpeed * Time.deltaTime);
            //_PlayerRB.velocity -= transform.right * _LRSpeed;
        }
        else if (Input.GetKeyUp("left") && _Grounded == true)
        {
            _PlayerRB.velocity = Vector3.zero;
        }

        if (Input.GetKeyDown("space") && _Grounded == true)                             //If space bar is down and grounded is true
        {
            _IsJumping = true;   
        }
    }

    void FixedUpdate()
    {
        //JUMPING//-----------------------------------------------------------------------------------------------------------------------------------------

        if (_IsJumping == true)
        {
            _PlayerRB.velocity = transform.up * _JumpSpeed * 100 * Time.deltaTime;
        }

        if (_JumpHeightMet == true)
        {
            _IsJumping = false;
            _PlayerRB.velocity -= transform.up * _JumpSpeed * 100 * Time.deltaTime;
        }

        //GROUND DETECTION RAYCAST
        RaycastHit GroundedHitInfo;
        Physics.Raycast(transform.position, -transform.up, out GroundedHitInfo, 3.5f);
        Debug.DrawRay(transform.position, -transform.up * 3.5f, Color.blue);

        if (GroundedHitInfo.collider == false)
        {
            _Grounded = false;
        }
        if (GroundedHitInfo.collider == true)
        {
            _Grounded = true;
        }

        //MAX JUMP HEIGHT DETECTION RAYCAST
        RaycastHit JumpHeightHit;
        Physics.Raycast(transform.position, -transform.up, out JumpHeightHit, 10);

        if (JumpHeightHit.collider == false)
        {
            _JumpHeightMet = true;
        }
        if (JumpHeightHit.collider == true)
        {
            _JumpHeightMet = false;
        }

        //CONSTANT ELEMENTS//

        //GRAVIT CONSTANT
        _PlayerRB.AddForce(-transform.up * _Gravity * 100 * Time.deltaTime);

        //ENDLESS RUNNING CONSTANT
        transform.position += transform.forward * _RunSpeed * Time.deltaTime;

        //CLMAPS VELOCITY TO STOP PLAYER FROM MOVING OVER "_maxspeed"
        _PlayerRB.velocity = Vector3.ClampMagnitude(_PlayerRB.velocity, _LRMaxSpeed);
    }

}
