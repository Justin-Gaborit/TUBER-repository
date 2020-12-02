using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemTrigger : MonoBehaviour
{
    public GameObject Totem;
    public GameObject Projectile_SpawnLoaction;
    public GameObject Totem_Projectile;
    public Transform ProjectileSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Totem = transform.parent.gameObject;
        Totem_Projectile = Resources.Load("Zone_4_TotemProjectile") as GameObject;
        Projectile_SpawnLoaction = Totem.transform.GetChild(2).gameObject;
        ProjectileSpawn = Projectile_SpawnLoaction.transform;
        
    }
    void OnTriggerEnter(Collider colides)
    {
        Vector3 ProjectileSpawnLocation = ProjectileSpawn.position + new Vector3();

        if (colides.gameObject.tag == "PlayerObject")
        {
            Instantiate(Totem_Projectile, ProjectileSpawnLocation, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
