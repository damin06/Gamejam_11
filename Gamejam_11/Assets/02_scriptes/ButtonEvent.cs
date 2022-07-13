using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void SceneLoader(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    ExitManager exitManager;
    OptionManager optionManager;
    HelpManager helpManager;
    StartAmi startAmi;

    private void Start()
    {
        exitManager = FindObjectOfType<ExitManager>();
        optionManager = FindObjectOfType<OptionManager>();
        helpManager = FindObjectOfType<HelpManager>();
        startAmi = FindObjectOfType<StartAmi>();
    }

    public void StartButton()
    {
        startAmi.AmiStart = true;
    }

    public void ExitButton()
    {
        exitManager.ExitClick = true;
    }

    public void ExitYesButton()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }

    public void ExitNoButton()
    {
        exitManager.ExitClick = false;
    }


    public void OptionButton()
    {
        optionManager.click = true;
    }

    public void OptionExit()
    {
        optionManager.click = false;
    }


    public void Option_Language()
    {
        if (GameControl.control.Language == true)
        {
            GameControl.control.Language = false;
            optionManager.CatPosition();
        }
        else
        {
            GameControl.control.Language = true;
            optionManager.CatPosition();
        }
    }

    public void Option_Sound()
    {
        optionManager.Sound_on_off();
    }

    public void Option_SoundEffect()
    {
        optionManager.SoundEffect_on_off();
    }

    public void Option_Vibration()
    {
        optionManager.Vibration_on_off();
    }


    public void HelpButton()
    {
        helpManager.HelpClick = true;
    }

    public void HelpNoButton()
    {
        helpManager.HelpClick = false;
    }
}
