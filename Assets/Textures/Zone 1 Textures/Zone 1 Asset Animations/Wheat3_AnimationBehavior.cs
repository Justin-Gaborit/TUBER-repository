using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat3_AnimationBehavior : MonoBehaviour
{
    Animator animator;
    bool Animation_Triggered;

    void Start()
    {
        animator = GetComponent<Animator>();
        Animation_Triggered = false;
    }

    void OnColliderEnter(Collider2D EnterWheatCollision)
    {
        if (EnterWheatCollision.gameObject.tag == "PlayerObject")
        {
            Animation_Triggered = true;
            Debug.Log("Hit");
        }
    }

    void Update()
    {
        if (Animation_Triggered == true)
        {
            animator.SetInteger("Crush_Animation", 1);
        }
    }
}
