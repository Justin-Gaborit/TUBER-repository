using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        Scene CurrentScene = SceneManager.GetActiveScene();
        string SceneName = CurrentScene.name;

        if (SceneName == "DeathScene")
        {
            DistanceText = GameObject.Find("Distance_Text").GetComponent<Text>();
            Player.SetActive(false);
        }

        if (SceneName == "MainMenu")
        {
            Destroy(Player);
            Destroy(gameObject);
        }
    }
}
