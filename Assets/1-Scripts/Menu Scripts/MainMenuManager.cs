using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject TUBER_Title;          //Establishes a public game object that holds the menu logo.
    public Animator TUBERTitleAnimator;     //Establishes a public animator that holds the TUBER logo animator.

    public GameObject ButtonRun;
    public Animator ButtonRunAnimator;

    public GameObject ButtonControls;
    public Animator ButtonControlsAnimator;

    public GameObject ButtonOptions;
    public Animator ButtonOptionsAnimator;

    public GameObject ButtonCredits;
    public Animator ButtonCreditsAnimator;

    public GameObject ButtonExit;
    public Animator ButtonExitAnimator;

    public GameObject Start_Button;         //Establishes a public game object that holds the "press any button text".
    public Animator StartButtonAnimator;    //Establishes a public animator that holds the "press any button text" animator.

    public GameObject Menu_Button_Container;
    public GameObject ControlsPanel;
    public GameObject CreditsPanel;
    public GameObject OptionsPanel;

    public GameObject Intro_Panel;
    public GameObject By_Text;
    public GameObject Justin_Text;
    public GameObject Tuber_Image;

    public GameObject MainMenu_BG_Audio;
    public AudioSource SFX_1;
    public AudioSource SFX_2;

    void Start()
    {
        StartCoroutine(myFunction());

        TUBERTitleAnimator = TUBER_Title.GetComponent<Animator>();      //Sets the "TUBERTitleAnimator" to the animator attached to the "TUBER_Title" game object.
        StartButtonAnimator = Start_Button.GetComponent<Animator>();    //Sets the "StartButtonAnimator" to the animator attached to the "Start_Button" game object.

        ButtonRunAnimator = ButtonRun.GetComponent<Animator>();
        ButtonRunAnimator.speed = 0;

        ButtonControlsAnimator = ButtonControls.GetComponent<Animator>();
        ButtonControlsAnimator.speed = 0;

        ButtonOptionsAnimator = ButtonOptions.GetComponent<Animator>();
        ButtonOptionsAnimator.speed = 0;

        ButtonCreditsAnimator = ButtonCredits.GetComponent<Animator>();
        ButtonCreditsAnimator.speed = 0;

        ButtonExitAnimator = ButtonExit.GetComponent<Animator>();
        ButtonExitAnimator.speed = 0;
    }

    void StartMainMenuSystem()
    {
        bool TUBER_Title_Anim1 = false;

        if (TUBERTitleAnimator.GetCurrentAnimatorStateInfo(0).IsName("TUBERMenuTitle_Anim1") &&
            TUBERTitleAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            TUBER_Title_Anim1 = true;
        }

        if (TUBER_Title_Anim1 == true && Input.anyKey)
        {
            Start_Button.SetActive(false);
            TUBERTitleAnimator.SetInteger("TUBER_Title_MenuEvent_1", 1);
            ButtonRunAnimator.speed = 1;
            ButtonControlsAnimator.speed = 1;
            ButtonOptionsAnimator.speed = 1;
            ButtonCreditsAnimator.speed = 1;
            ButtonExitAnimator.speed = 1;
        }
    }

    //Main Menu Buttons
    public void RunButtonPressed()
    {
        SceneManager.LoadScene("RunScene");
    }
    public void ControlsButtonPressed()
    {
        ControlsPanel.gameObject.SetActive(true);
    }

    public void CreditsButtonPressed()
    {
        CreditsPanel.gameObject.SetActive(true);
    }

    public void OptionsButtonPressed()
    {
        OptionsPanel.gameObject.SetActive(true);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }

    //Resolution Buttons
    public void Button1920X1080()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void Button1600X900()
    {
        Screen.SetResolution(1600, 900, true);
    }
    public void Button1536X864()
    {
        Screen.SetResolution(1536, 864, true);
    }
    public void Button1440X900()
    {
        Screen.SetResolution(1440, 900, true);
    }
    public void Button1366X768()
    {
        Screen.SetResolution(1366, 768, true);
    }
    public void Button1280X720()
    {
        Screen.SetResolution(1280, 720, true);
    }

    //Windowed Buttons
    public void WindowedButton_OnOff()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    //Panel Back Buttons
    public void ControlsPanelBackButtonPressed()
    {
        ControlsPanel.gameObject.SetActive(false);
    }

    public void CreditsPanelBackButtonPressed()
    {
        CreditsPanel.gameObject.SetActive(false);
    }

    public void OptionsPanelBackButtonPressed()
    {
        OptionsPanel.gameObject.SetActive(false);
    }


    IEnumerator myFunction()
    {
        yield return new WaitForSeconds(1);
        By_Text.gameObject.SetActive(true);
        SFX_2.Play();

        yield return new WaitForSeconds(1.2f);
        Justin_Text.gameObject.SetActive(true);
        Tuber_Image.gameObject.SetActive(true);
        SFX_1.Play();

        yield return new WaitForSeconds(4);
        Intro_Panel.gameObject.SetActive(false);
        TUBER_Title.gameObject.SetActive(true);
        Start_Button.gameObject.SetActive(true);
        Menu_Button_Container.gameObject.SetActive(true);
        MainMenu_BG_Audio.gameObject.SetActive(true);
    }



    // Update is called once per frame
    void Update()
    {
        StartMainMenuSystem();
    }
}
