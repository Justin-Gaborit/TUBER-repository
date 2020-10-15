using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGeneration : MonoBehaviour
{
    public GameObject set1;
    public GameObject set2;
    public GameObject set3;

    void Start()
    {
        set1 = Resources.Load("Cell_1") as GameObject;
        set2 = Resources.Load("Cell_2") as GameObject;
        set3 = Resources.Load("Cell_3") as GameObject;
    }


    private void OnTriggerEnter(Collider collision)
    {

        Vector3 SpawnLocation = new Vector3();
        SpawnLocation = GameObject.Find("SpawnLoc").transform.position;


        if (collision.gameObject.name == "PlayerObject")
        {
            int random = Random.Range(1, 4);
            switch (random)
            {
                case 1:
                    Instantiate(set1, SpawnLocation, Quaternion.identity);
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;

                case 2:
                    Instantiate(set2, SpawnLocation, Quaternion.identity);
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;

                case 3:
                    Instantiate(set3, SpawnLocation, Quaternion.identity);
                    Destroy(GameObject.Find("SpawnLoc"));
                    Debug.Log("Collided");
                    Destroy(gameObject);
                    break;
            }
        }
    }

}