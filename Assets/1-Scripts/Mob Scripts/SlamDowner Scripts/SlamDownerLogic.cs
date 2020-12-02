using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamDownerLogic : MonoBehaviour
{
    public GameObject SlamDowner;
    public Animator animator;
    public int RandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        animator = SlamDowner.GetComponent<Animator>();
        RandomNumber = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        if (RandomNumber == 1)
        {
            animator.SetInteger("Condition_1", 1);
        }

        if (RandomNumber == 2)
        {
            animator.SetInteger("Condition_2", 1);
        }

        if (RandomNumber == 3)
        {
            animator.SetInteger("Condition_3", 1);
        }

        if (RandomNumber == 4)
        {
            animator.SetInteger("Condition_1", 1);
        }

        if (RandomNumber == 5)
        {
            animator.SetInteger("Condition_2", 1);
        }

        if (RandomNumber == 6)
        {
            animator.SetInteger("Condition_3", 1);
        }
    }
}
