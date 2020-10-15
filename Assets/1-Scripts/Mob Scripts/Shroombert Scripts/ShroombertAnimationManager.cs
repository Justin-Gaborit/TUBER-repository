using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShroombertAnimationManager : MonoBehaviour
{
    public GameObject Mob;
    Animator MobAnimator;

    // Start is called before the first frame update
    void Start()
    {
        MobAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mob.GetComponent<MobMoveLeftRight>().RandomNumber == 1)
        {
            MobAnimator.SetInteger("Condition_Right_Red", 1);
        }

        if (Mob.GetComponent<MobMoveLeftRight>().RandomNumber == 2)
        {
            MobAnimator.SetInteger("Condition_Left_Red", 1);
        }

        if (Mob.GetComponent<MobMoveLeftRight>().RandomNumber == 3)
        {
            MobAnimator.SetInteger("Condition_Right_Blue", 1);
        }

        if (Mob.GetComponent<MobMoveLeftRight>().RandomNumber == 4)
        {
            MobAnimator.SetInteger("Condition_Left_Blue", 1);
        }

        if (Mob.GetComponent<MobMoveLeftRight>().RandomNumber == 5)
        {
            MobAnimator.SetInteger("Condition_Right_Orange", 1);
        }

        if (Mob.GetComponent<MobMoveLeftRight>().RandomNumber == 6)
        {
            MobAnimator.SetInteger("Condition_Left_Orange", 1);
        }
    }
}
