using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CharacterTriggerManager : MonoBehaviour
{
    /* Establishes game objects */
    public GameObject Player;

    public Animator PlayerAnimator;

    /* Establishes integers */
    public int PlayerHealth;
    public int Doubloons;
    public int PlayerDistance;

    /* Establishes floats*/
    public float Zippy_CountDown;   /* Stores time value that Zippy item buff starts counting down from */

    /* Establishes public bools */
    public bool PlayerDead;         /* Public bool dictates if the player is dead or not */
    public bool ZippyBuff_on;       /* Stores bool if Zippy item buff is on or not */

    private void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
        PlayerDead = false;     /* The player dead bool is set to false by default */
        ZippyBuff_on = false;   /* The Zippy item buff is set to "false" by default */
        Zippy_CountDown = 10f;  /* This is the length of time that passes before the zippy buff wares off */
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

        /* Zippy Trigger (Occurs when player hits zippy item and gains temporary speed buff) */
        if (colides.gameObject.tag == "ItemTag_Zippy")
        {
            ZippyBuff_on = true;
            Destroy(colides.gameObject);
            Debug.Log("Distance Collided");
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
        }

    }

    /* This function contains the methods regarding the player death state */
    /* If the players health is equal to 0, they are dead. When the player */
    /* dies, the following takes place. */
    void PlayerDeath()
    {
        Player.GetComponent<CharacterControllerV2>()._RunSpeed -= 10 * Time.deltaTime;
        Player.GetComponent<CharacterControllerV2>()._LRSpeed -= 3.5f * Time.deltaTime;
        Player.GetComponent<CharacterControllerV2>()._Gravity = 10000;

        if (Player.GetComponent<CharacterControllerV2>()._RunSpeed <= 0)
        {
            Player.GetComponent<CharacterControllerV2>()._RunSpeed = 0;
        }

        if (Player.GetComponent<CharacterControllerV2>()._LRSpeed <= 0)
        {
            Player.GetComponent<CharacterControllerV2>()._LRSpeed = 0;
        }

        if (Player.GetComponent<CharacterControllerV2>()._LRSpeed == 0)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }

    /* This function contains the methods regarding the Zippy item buff */
    void ZippyBuff()
    {
        if (Zippy_CountDown >= 0)   /* If "Zippy_CountDown" is greater than or equal to 0 */
        {
            Zippy_CountDown -= Time.deltaTime;
            Player.GetComponent<CharacterControllerV2>()._RunSpeed = 80;
        }

        if (Zippy_CountDown <= 0)   /* If "Zippy_CountDown" is less than or equal to 0 */
        {
            Player.GetComponent<CharacterControllerV2>()._RunSpeed = 40;
            Zippy_CountDown = 0f;
            ZippyBuff_on = false;
            Zippy_CountDown = 10f;
        }
    }

    void Update()
    {
        /* These if statement make sure that the players health value */
        /* Remains within the range of 0-3 at any given time */
        if (PlayerHealth >= 3)
        {
            PlayerHealth = 3;
        }
        if (PlayerHealth <= 0)
        {
            PlayerHealth = 0;
        }

        /* If "Doubloons" is less than 0 */
        if (Doubloons < 0)    
        {
            Doubloons = 0;          /* "Doubloon" is equal to zero */
        }

        /* If "PlayerHealth" int from "CharacterTriggerManager" script is equal to zero */
        if (PlayerHealth == 0)
        {
            PlayerDeath();
        }

        /* If "ZippyBuff_on" is set to true*/
        if (ZippyBuff_on == true)   
        {
            ZippyBuff();            /* ZippyBuff function is run */
        }
    }
}
