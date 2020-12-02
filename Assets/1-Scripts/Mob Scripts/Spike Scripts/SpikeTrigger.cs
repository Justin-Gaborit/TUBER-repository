using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrigger : MonoBehaviour
{
    public GameObject Spike;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = Spike.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider colides)
    {
        if (colides.gameObject.tag == "PlayerObject")
        {
            animator.SetInteger("Condition_Activate", 1);
        }
    }
}
