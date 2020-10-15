using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScript : MonoBehaviour
{
    public GameObject By_Title;
    public GameObject Name_Title;
    public GameObject Tuber_Logo;
    //public AudioSource Sound1;
    //public AudioSource Sound2;

    void Start()
    {
        StartCoroutine(myFunction());
    }

    IEnumerator myFunction()
    {
        yield return new WaitForSeconds(1);
        By_Title.gameObject.SetActive(true);
        //Sound1.Play();

        yield return new WaitForSeconds(1.2f);
        Name_Title.gameObject.SetActive(true);
        Tuber_Logo.gameObject.SetActive(true);
        //Sound2.Play();

        yield return new WaitForSeconds(4);
    }
}
