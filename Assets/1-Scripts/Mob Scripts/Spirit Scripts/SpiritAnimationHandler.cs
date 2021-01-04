using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritAnimationHandler : MonoBehaviour
{
    public GameObject Mob;
    Animator MobAnimator;

    // Start is called before the first frame update
    void Start()
    {
        Mob = this.gameObject;
        MobAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mob.GetComponent<SpiritMoveLeftRight>().RandomNumber == 1)
        {
            MobAnimator.SetInteger("Condition_Moving", 1);
        }

        if (Mob.GetComponent<SpiritMoveLeftRight>().RandomNumber == 2)
        {
            MobAnimator.SetInteger("Condition_Moving", 1);
        }

        if (Mob.GetComponent<SpiritMoveLeftRight>().RandomNumber == 3)
        {
            MobAnimator.SetInteger("Condition_Moving", 1);
        }

        if (Mob.GetComponent<SpiritMoveLeftRight>().RandomNumber == 4)
        {
            MobAnimator.SetInteger("Condition_Moving", 1);
        }

        if (Mob.GetComponent<SpiritMoveLeftRight>().RandomNumber == 5)
        {
            MobAnimator.SetInteger("Condition_Moving", 1);
        }

        if (Mob.GetComponent<SpiritMoveLeftRight>().RandomNumber == 6)
        {
            MobAnimator.SetInteger("Condition_Moving", 1);
        }
    }
}
