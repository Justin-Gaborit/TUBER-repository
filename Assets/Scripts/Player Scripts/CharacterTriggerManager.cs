using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTriggerManager : MonoBehaviour
{
    /* This section of code contains all the different value tyoes that the player has*/

    public int PlayerHealth;
    public int Doubloons;
    public int PlayerDistance;

    private void Start()
    {
    
    }

    /* This section of code lists all the collision interactions the character has with game objects */
    void OnTriggerEnter(Collider colides)
    {
        /* DAMAGE TRIGGER (Occurs when player hits hostile objects and is hurt) */
        if (colides.gameObject.tag == "DamageCollider")
        {
            PlayerHealth -= 1;
            Destroy(colides.gameObject);
            Debug.Log("Damage Collided");
        }

        /* CHICKEN ITEM TRIGGER (Occurs when player hits chicken item and gains health) */
        if (colides.gameObject.tag == "ItemTag_ChickenLeg")
        {
            PlayerHealth += 1;
            Destroy(colides.gameObject);
            Debug.Log("ChickenLeg Collided");
        }

        /* DOUBLOON ITEM TRIGGER (Occurs when player hits doubloon item and gains currency) */
        if (Doubloons < 10 && colides.gameObject.tag == "ItemTag_Doubloon")
        {
            Doubloons += 1;
            Destroy(colides.gameObject);
            Debug.Log("Doubloon Collided");
        }
        else 
        { 
            Doubloons += 0; 
        }

        /* Distance Trigger (Occurs when player hits distance trigger) */
        if (colides.gameObject.tag == "Distance_Trigger")
        {
            PlayerDistance += 1;
            Destroy(colides.gameObject);
            Debug.Log("Distance Collided");
        }

    }

    void Update()
    {
        if (PlayerHealth >= 3)
        {
            PlayerHealth = 3;
        }
        if (PlayerHealth <= 0)
        {
            PlayerHealth = 0;
        }

        if (Doubloons < 0)
        {
            Doubloons = 0;
        }
    }
}
