using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_Zone_1 : MonoBehaviour
{
    public GameObject Loop1;


    void Start()
    {
        Loop1 = Resources.Load("Zone1_Cell2") as GameObject;

    }


    private void OnTriggerEnter(Collider collision)
    {

        Vector3 SpawnLocation = new Vector3();
        SpawnLocation = GameObject.Find("SpawnLoc").transform.position;


        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 1);
            switch (random)
            {
                case 1:
                    Instantiate(Loop1, SpawnLocation, Quaternion.identity);
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }
        }
    }

}