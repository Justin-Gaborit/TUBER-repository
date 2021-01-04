using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShufflerAnimationManager : MonoBehaviour
{
    public GameObject Mob;
    Animator MobAnimator;

    // Start is called before the first frame update
    void Start()
    {
        MobAnimator = GetComponent<Animator>();
        Mob = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mob.GetComponent<ShufflerMoveLeftRight>().RandomNumber == 1)
        {
            MobAnimator.SetInteger("Condition_Right", 1);
        }

        if (Mob.GetComponent<ShufflerMoveLeftRight>().RandomNumber == 2)
        {
            MobAnimator.SetInteger("Condition_Left", 1);
        }

        if (Mob.GetComponent<ShufflerMoveLeftRight>().RandomNumber == 3)
        {
            MobAnimator.SetInteger("Condition_Right", 1);
        }

        if (Mob.GetComponent<ShufflerMoveLeftRight>().RandomNumber == 4)
        {
            MobAnimator.SetInteger("Condition_Left", 1);
        }

        if (Mob.GetComponent<ShufflerMoveLeftRight>().RandomNumber == 5)
        {
            MobAnimator.SetInteger("Condition_Right", 1);
        }

        if (Mob.GetComponent<ShufflerMoveLeftRight>().RandomNumber == 6)
        {
            MobAnimator.SetInteger("Condition_Left", 1);
        }
    }
}
