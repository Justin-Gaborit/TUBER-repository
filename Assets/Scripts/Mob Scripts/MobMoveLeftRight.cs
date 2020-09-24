using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMoveLeftRight : MonoBehaviour
{
    public GameObject Mob;
    public Rigidbody MobRB;

    Vector3 MobCenter;

    public RaycastHit HitInfo;

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
        MobRB = GetComponent<Rigidbody>();

        MobGravity = 10;
        MobMoveSpeed = 8;
        RandomNumber = Random.Range(1,7);

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
        }

        if (RandomNumber == 2)
        {
            transform.Translate(-Vector3.right * MobMoveSpeed * Time.deltaTime);
        }

        if (RandomNumber == 3)
        {
            transform.Translate(Vector3.right * MobMoveSpeed * Time.deltaTime);
        }

        if (RandomNumber == 4)
        {
            transform.Translate(-Vector3.right * MobMoveSpeed * Time.deltaTime);
        }

        if (RandomNumber == 5)
        {
            transform.Translate(Vector3.right * MobMoveSpeed * Time.deltaTime);
        }

        if (RandomNumber == 6)
        {
            transform.Translate(-Vector3.right * MobMoveSpeed * Time.deltaTime);
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
