using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCell_Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider DestructionTrigger)
    {
        Destroy(transform.parent.gameObject);
        Debug.Log("Cell Destroyed");
    }
}
