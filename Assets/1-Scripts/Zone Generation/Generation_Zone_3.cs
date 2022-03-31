using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_Zone_3 : MonoBehaviour
{
    public GameObject[] CellArray;
    public GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("PlayerObject");

        CellArray[0] = Resources.Load("Zone3_Cell_0") as GameObject;
        CellArray[1] = Resources.Load("Zone3_Cell_4") as GameObject;
        CellArray[2] = Resources.Load("Zone3_Cell_2") as GameObject;
        CellArray[3] = Resources.Load("Zone3_Cell_3") as GameObject;
        CellArray[4] = Resources.Load("Zone3_Cell_4") as GameObject;
        CellArray[5] = Resources.Load("Zone3_Cell_4") as GameObject;
    }

    void Update()
    {
        if (Player.GetComponent<CharacterTriggerManager>().PlayerDistance > 500)
        {
            CellArray[1] = Resources.Load("Zone3_Cell_Zone4Trigger") as GameObject;
            CellArray[3] = Resources.Load("Zone3_Cell_Zone4Trigger") as GameObject;
            CellArray[5] = Resources.Load("Zone3_Cell_Zone4Trigger") as GameObject;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        Vector3 SpawnLocation = new Vector3();
        SpawnLocation = GameObject.Find("SpawnLoc").transform.position;

        if (collision.gameObject.tag == "PlayerObject")
        {
            int RandomInt = Random.Range(0, 6);
            Instantiate(CellArray[RandomInt], SpawnLocation, Quaternion.identity);
            Destroy(GameObject.Find("SpawnLoc"));
            Debug.Log("Collided and Cell Generated");
            Destroy(gameObject);

            if (RandomInt == 0)
            {
                Debug.Log("Zone3_Cell_0");
            }

            if (RandomInt == 1)
            {
                Debug.Log("Zone3_Cell_1");
            }

            if (RandomInt == 2)
            {
                Debug.Log("Zone3_Cell_2");
            }

            if (RandomInt == 3)
            {
                Debug.Log("Zone3_Cell_3");
            }

            if (RandomInt == 4)
            {
                Debug.Log("Zone3_Cell_4");
            }

            if (RandomInt == 5)
            {
                Debug.Log("Zone3_Cell_Zone4Trigger");
            }
        }
    }
}
