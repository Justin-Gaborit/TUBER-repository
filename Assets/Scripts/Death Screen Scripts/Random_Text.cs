using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Random_Text : MonoBehaviour
{
    public Text RandomText;
    public string[] StringArray;
    public int RandomInt;

    void Start()
    {
        RandomInt = Random.Range(0, 24);

        StringArray[0] = "better luck next time :(";
        StringArray[1] = "my mom got farther";
        StringArray[2] = "soo tragic...";
        StringArray[3] = "give it another go!";
        StringArray[4] = "you ran out of chicken?";

        StringArray[5] = "you had one job...";
        StringArray[6] = "better luck next time bucko";
        StringArray[7] = "my dog is better at this game";
        StringArray[8] = "get good sun";
        StringArray[9] = "you died";

        StringArray[10] = "you are filled with... determination";
        StringArray[11] = "dont you wanna know whats at the end?";
        StringArray[12] = "you are quite the tuber my dude";
        StringArray[13] = "may your children live on in harmony";
        StringArray[14] = "what will your children do without you?";

        StringArray[15] = "the ncr would be proud";
        StringArray[16] = "everyone liked that";
        StringArray[17] = "another tuber needs your help";
        StringArray[18] = "the legion would be proud";
        StringArray[19] = "pwned";

        StringArray[20] = "Chris Peer-Groves is a really long name!";
        StringArray[21] = "THATS A LOTTA TUBES!!";
        StringArray[22] = "just another freak in the freak kingdom";
        StringArray[23] = "next time 'dodge' the obstacle";
        StringArray[24] = "tell me, is failure painful?";
    }

    // Update is called once per frame
    void Update()
    {
        RandomText.text = (StringArray[RandomInt]);
    }
}
