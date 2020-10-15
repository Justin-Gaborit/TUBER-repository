using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacto_RightTrigger : MonoBehaviour
{
    public GameObject Cacto;
    public GameObject TriggerLeft_obj;
    public GameObject TriggerCenter_obj;
    public GameObject TriggerRight_obj;

    // Start is called before the first frame update
    void Start()
    {
        Cacto = transform.parent.gameObject;
        TriggerRight_obj = gameObject;
    }

    void OnTriggerEnter(Collider colides)
    {
        if (colides.gameObject.tag == "PlayerObject")
        {
            Cacto.GetComponent<CactoManagerAI>().TriggerRight = true;
            Destroy(TriggerLeft_obj);
            Destroy(TriggerCenter_obj);
            Destroy(gameObject);
            Debug.Log("Cacto Collision Right");
        }
    }
}
