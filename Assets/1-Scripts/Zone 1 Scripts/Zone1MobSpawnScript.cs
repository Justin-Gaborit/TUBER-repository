using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone1MobSpawnScript : MonoBehaviour
{
    public GameObject MobSpawner;
    public Vector3 ObjectLocation;
    public GameObject[] SpawnableMobs;
    public int RandomInt;

    // Start is called before the first frame update
    void Start()
    {
        ObjectLocation = gameObject.transform.position;
        float MobSpawnerZRotation = MobSpawner.transform.eulerAngles.z;
        RandomInt = Random.Range(1, 2);
        Instantiate(SpawnableMobs[RandomInt], ObjectLocation, Quaternion.Euler(0, 0, MobSpawnerZRotation));
    }

    void Update()
    {
        Destroy(gameObject);
    }
}
