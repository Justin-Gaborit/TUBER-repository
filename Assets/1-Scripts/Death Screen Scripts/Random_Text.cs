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

        StringArray[0] = "Better luck next time :(";
        StringArray[1] = "I used to lose at this game too...";
        StringArray[2] = "Soo tragic!";
        StringArray[3] = "Give it another go!";
        StringArray[4] = "You ran out of chicken?";

        StringArray[5] = "Ouch! That looked painful!";
        StringArray[6] = "Better luck next time friendo";
        StringArray[7] = "Try again! Next time you'll win!";
        StringArray[8] = "Wow.. That was kinda sad!";
        StringArray[9] = "You should be proud!";

        StringArray[10] = "you are filled with... determination!";
        StringArray[11] = "Try again, dont you wanna know whats at the end?";
        StringArray[12] = "you are quite the tuber my dude";
        StringArray[13] = "May your children live on in harmony";
        StringArray[14] = "Most players dont make it this far!";

        StringArray[15] = "PAX 2022 is pretty cool!";
        StringArray[16] = "Everyone liked that";
        StringArray[17] = "Another tuber needs your help";
        StringArray[18] = "PAX 2022 is pretty cool!";
        StringArray[19] = "PAX 2022 is pretty cool!";

        StringArray[20] = "THATS A LOTTA TUBES!!";
        StringArray[21] = "THATS A LOTTA TUBES!!";
        StringArray[22] = "THATS A LOTTA TUBES!!";
        StringArray[23] = "Next time 'dodge' the obstacle";
        StringArray[24] = "Tell me, is failure painful?";
    }

    // Update is called once per frame
    void Update()
    {
        RandomText.text = (StringArray[RandomInt]);
    }
}
