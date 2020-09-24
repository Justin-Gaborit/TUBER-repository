using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody PlayerRB;  
    Animator animator;
    private CharacterControllerV2 _GroundedBool;

    void Start()
    {
        animator = GetComponent<Animator>();                    //Gets ahold of animator
        PlayerRB = gameObject.GetComponent<Rigidbody>();        //Gets ahold of players rigidbody
        _GroundedBool = GetComponent<CharacterControllerV2>();    //Gets ahold of "CharacterController" script

    }

    void Update()
    {
        if (_GroundedBool._Grounded == false)                   //Uses "CharacterControllerV2" script _Grounded bool
        {
            animator.SetInteger("Condition_Jump", 1);
        }
        else
        {
            animator.SetInteger("Condition_Jump", 0);
        }

        if (Player.GetComponent<CharacterControllerV2>()._RunSpeed <= 39)       //Gets ahold of "_RunSpeed" from the "CharacterControllerV2" script and cheks if it's below 39
        {
            animator.SetInteger("Condition_Slowdown", 1);                       //If so then "Condition_Slowdown" is set to 1
        }

        if (Player.GetComponent<CharacterControllerV2>()._RunSpeed <= 3)        //Gets ahold of "_RunSpeed" from the "CharacterControllerV2" script and cheks if it's below 3
        {
            animator.SetInteger("Condition_Dead", 1);                           //If so then "Condition_Dead" is set to 1
        }
    }
}
