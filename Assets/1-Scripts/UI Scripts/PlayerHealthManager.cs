using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{
    public Sprite[] playerhealth_images;            //array stores index containing sprites from player healthbar sprite sheet
    public Image ImageRenderer;                     //gets a public image renderer
    public GameObject Player;                       //get public game object that is the player

    void Start()
    {
        ImageRenderer.sprite = playerhealth_images[0];  //sets the array index to zero so that the healthbar is full when the game starts
    }

    void Update()
    {
        if (Player.GetComponent<CharacterTriggerManager>().PlayerHealth == 3)   //this line accesses an integer from the "CharacterTriggerManager" script that is on the player object
        {                                                                       //if the previous method is equal to 3 then
            ImageRenderer.sprite = playerhealth_images[0];                      //then the image renderer attached to this object is set to index 0
        }                                                                       //the following lines work in the same manner

        if (Player.GetComponent<CharacterTriggerManager>().PlayerHealth == 1)
        {
            ImageRenderer.sprite = playerhealth_images[2];
        }

        if (Player.GetComponent<CharacterTriggerManager>().PlayerHealth == 2)
        {
            ImageRenderer.sprite = playerhealth_images[1];
        }

        if (Player.GetComponent<CharacterTriggerManager>().PlayerHealth == 0)
        {
            ImageRenderer.sprite = playerhealth_images[3];
        }
    }
}
