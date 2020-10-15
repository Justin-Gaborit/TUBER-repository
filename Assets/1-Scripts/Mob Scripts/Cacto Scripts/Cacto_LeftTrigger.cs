using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cacto_LeftTrigger : MonoBehaviour
{
    public GameObject Cacto;
    public GameObject TriggerLeft_obj;
    public GameObject TriggerCenter_obj;
    public GameObject TriggerRight_obj;

    // Start is called before the first frame update
    void Start()
    {
        Cacto = transform.parent.gameObject;
        TriggerLeft_obj = gameObject;
    }

    void OnTriggerEnter(Collider colides)
    {
        if (colides.gameObject.tag == "PlayerObject")
        {
            Cacto.GetComponent<CactoManagerAI>().TriggerLeft = true;
            Destroy(gameObject);
            Destroy(TriggerCenter_obj);
            Destroy(TriggerRight_obj);
            Debug.Log("Cacto Collision Left");
        }
    }
}
