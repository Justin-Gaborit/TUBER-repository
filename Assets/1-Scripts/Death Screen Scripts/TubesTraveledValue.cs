using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TubesTraveledValue : MonoBehaviour
{
    public GameObject Player;
    public Text TubesTraveledValue_Text;
    public int TubesDistanceInt;
    public string TubesDistanceString;

    // Start is called before the first frame update
    void Start()
    {

        TubesDistanceInt = Player.GetComponent<CharacterTriggerManager>().PlayerDistance;
        TubesDistanceString = TubesDistanceInt.ToString();
        TubesTraveledValue_Text.text = TubesDistanceString;
    }
}
