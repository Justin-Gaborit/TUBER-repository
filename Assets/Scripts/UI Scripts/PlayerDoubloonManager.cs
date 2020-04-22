using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerDoubloonManager : MonoBehaviour
{
    public Sprite[] DoubloonCount_images;           //array stores index containing sprites from player healthbar sprite sheet
    public Image ImageRenderer;                     //gets a public image renderer
    public GameObject Player;                       //get public game object that is the player
    // Start is called before the first frame update
    void Start()
    {
        ImageRenderer.sprite = DoubloonCount_images[0];  //sets the array index to zero so that the healthbar is full when the game starts
    }

    // Update is called once per frame
    void Update()
    {
        ImageRenderer.sprite = DoubloonCount_images[Player.GetComponent<CharacterTriggerManager>().Doubloons];
    }
}
