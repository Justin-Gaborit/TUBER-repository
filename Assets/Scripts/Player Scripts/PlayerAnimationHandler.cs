using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
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
    }
}
