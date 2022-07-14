using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AndroidBackManager : MonoBehaviour
{
    ExitManager exitManager;
    OptionManager optionManager;
    HelpManager helpManager;
    SkinHelpManager skinHelpManager;

    private void Start()
    {
        exitManager = FindObjectOfType<ExitManager>();
        optionManager = FindObjectOfType<OptionManager>();
        helpManager = FindObjectOfType<HelpManager>();
        skinHelpManager = FindObjectOfType<SkinHelpManager>();
    }

    void Update()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            if (SceneManager.GetActiveScene().name == "Start")
            {
                if (exitManager.ExitClick == true)
                {
                    if (Input.GetKey(KeyCode.Escape))
                    {
                        GameControl.control.Button();
                        exitManager.ExitClick = false;
                    }
                }
                else if (optionManager.click == false && helpManager.HelpClick == false)
                {
                    if (Input.GetKey(KeyCode.Escape))
                    {
                        GameControl.control.Button();
                        exitManager.ExitClick = true;
                    }
                }

            }

            if (SceneManager.GetActiveScene().name == "Skin")
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    GameControl.control.Button();
                    SceneManager.LoadScene("Start");
                }
            }

            if (SceneManager.GetActiveScene().name == "random")
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    GameControl.control.Button();
                    SceneManager.LoadScene("Skin");
                }
            }

            if (optionManager.click == true)
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    GameControl.control.Button();
                    optionManager.click = false;
                }
            }

            if (helpManager.HelpClick == true)
            {
                if (Input.GetKey(KeyCode.Escape))
                {
                    GameControl.control.Button();
                    helpManager.HelpClick = false;
                }
            }
        }
    }
}
