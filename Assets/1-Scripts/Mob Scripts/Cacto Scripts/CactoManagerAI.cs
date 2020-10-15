using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactoManagerAI : MonoBehaviour
{
    public GameObject Mob;
    public GameObject TriggerLeft_obj;
    public GameObject TriggerCenter_obj;
    public GameObject TriggerRight_obj;

    public Rigidbody MobRB;

    //public RaycastHit HitInfo;

    Animator animator;

    public int RandomNumber;
    public float MobGravity;
    public float MobMoveSpeed;
    public float rotTime;

    public bool MobCanMove;
    public bool TriggerLeft;
    public bool TriggerCenter;
    public bool TriggerRight;

    // Start is called before the first frame update
    void Start()
    {
        rotTime = 0.2f;
        rotTime = rotTime + Time.deltaTime;

        animator = GetComponent<Animator>();
        MobRB = GetComponent<Rigidbody>();
        TriggerLeft_obj = Mob.transform.Find("TriggerLeft").gameObject;
        TriggerCenter_obj = Mob.transform.Find("TriggerCenter").gameObject;
        TriggerRight_obj = Mob.transform.Find("TriggerLeft").gameObject;

        MobGravity = 10;
        MobMoveSpeed = 17;
        RandomNumber = Random.Range(1, 3);

        MobCanMove = true;
        TriggerLeft = false;
        TriggerCenter = false;
        TriggerRight = false;
    }

    void CactoMovingLeftRight()
    {
        if (RandomNumber == 1)
        {
            transform.Translate(-Vector3.right * MobMoveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.right * MobMoveSpeed * Time.deltaTime);
        }
    }

    void CactoMovingLeft()
    {
        transform.Translate(-Vector3.right * MobMoveSpeed * Time.deltaTime);
    }

    void CactoMovingRight()
    {
        transform.Translate(Vector3.right * MobMoveSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (TriggerCenter == true)
        {
            animator.SetInteger("Condition_Start", 1);
            CactoMovingLeftRight();
        }

        if (TriggerLeft == true)
        {
            animator.SetInteger("Condition_Start", 1);
            CactoMovingLeft();
        }

        if (TriggerRight == true)
        {
            animator.SetInteger("Condition_Start", 1);
            CactoMovingRight();
        }
    }

    void FixedUpdate()
    {
        RaycastHit HitInfo;

        if (Physics.Raycast(transform.position, -transform.up, out HitInfo, Mathf.Infinity))
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, HitInfo.transform.localRotation, rotTime);
        }

        MobRB.AddForce(-transform.up * MobGravity * 100 * Time.deltaTime);
    }
}
