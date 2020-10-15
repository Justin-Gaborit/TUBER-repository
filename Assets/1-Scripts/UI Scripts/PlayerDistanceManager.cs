using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDistanceManager : MonoBehaviour
{
    public Text DistanceText;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        DistanceText = GameObject.Find("Distance_Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        DistanceText.text = Player.GetComponent<CharacterTriggerManager>().PlayerDistance.ToString();
    }
}
