using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TumbleWeedMove_LeftRight : MonoBehaviour
{
    public GameObject Mob;
    public Rigidbody MobRB;

    public RaycastHit HitInfo;
    Animator animator;

    public int RandomNumber;
    public float MobGravity;
    public float MobMoveSpeed;
    public float rotTime;

    public bool MobCanMove;
    public bool Orientation;
    public bool MobExists;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        MobRB = GetComponent<Rigidbody>();

        MobGravity = 10;
        MobMoveSpeed = 40;
        RandomNumber = Random.Range(1, 3);

        MobCanMove = true;
        Orientation = true;
        MobExists = true;

        rotTime = rotTime + Time.deltaTime;
    }

    void MobMoving()
    {
        if (RandomNumber == 1)
        {
            transform.Translate(Vector3.right * MobMoveSpeed * Time.deltaTime);
            animator.SetInteger("Condition_Right", 1);
        }

        if (RandomNumber == 2)
        {
            transform.Translate(-Vector3.right * MobMoveSpeed * Time.deltaTime);
            animator.SetInteger("Condition_Left", 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MobCanMove == true)
        {
            MobMoving();
        }
    }

    void FixedUpdate()
    {

        if (Physics.Raycast(transform.position, -transform.up, out HitInfo, Mathf.Infinity))
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, HitInfo.transform.localRotation, rotTime);
        }
        else
        {
            Destroy(gameObject);
        }

        MobRB.AddForce(-transform.up * MobGravity * 100 * Time.deltaTime);
    }
}
