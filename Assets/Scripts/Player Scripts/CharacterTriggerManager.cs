using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTriggerManager : MonoBehaviour
{
    /* This section of code lists all the collision interactions the character has with game objects */
    
    void OnTriggerEnter(Collider colides)
    {
        /* DAMAGE TRIGGER (Occurs when player hits hostile objects and is hurt) */
        if (colides.gameObject.tag == "DamageCollider")
        {
            Debug.Log("Damage Collided");
        }

        /* CHICKEN ITEM TRIGGER (Occurs when player hits chicken item and gains health) */
        if (colides.gameObject.tag == "ItemTag_ChickenLeg")
        {
            Destroy(colides.gameObject);
            Debug.Log("ChickenLeg Collided");
        }
    }
}
