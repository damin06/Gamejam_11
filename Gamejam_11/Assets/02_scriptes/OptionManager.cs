using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    public bool click = false;
    public GameObject Option;
    public GameObject OptionTool;

    public AudioSource startBGM;
    public GameObject Sound_On;
    public GameObject Sound_Off;


    ButtonEvent buttonEvent;
    [SerializeField] Text Title;
    [SerializeField] Text Exit;
    [SerializeField] Text ExitNo;
    [SerializeField] Text ExitYes;
    [SerializeField] Text OptionText;
    [SerializeField] Text Option_Language;
    [SerializeField] Text Option_Vibration;
    [SerializeField] Text Option_SoundEffect;
    [SerializeField] Text Help;


    public GameObject Cat;


    private void Start()
    {
        buttonEvent = FindObjectOfType<ButtonEvent>();
    }

    void Update()
    {
        if (click == true)
        {
            Option.SetActive(true);
            OptionTool.SetActive(true);
        }

        if (click == false)
        {
            Option.SetActive(false);
            OptionTool.SetActive(false);
        }

        if (GameControl.control.Language == false)
        {
            Cat.transform.position = new Vector3(680, 1635, 0);
            Title.text = "고양이 구르다";
            Exit.text = "정말 나가실건가요?";
            ExitNo.text = "아니요";
            ExitYes.text = "네";
            OptionText.text = "설정";
            Option_Language.text = "English";
            Option_Vibration.text = "진동";
            Option_SoundEffect.text = "효과음";
            Help.text = "도움";
        }
        else
        {
            Cat.transform.position = new Vector3(542, 1317, 0);
            Title.text = "Cat Roll";
            Exit.text = "Are you really going out?";
            ExitNo.text = "No";
            ExitYes.text = "Yes";
            OptionText.text = "Option";
            Option_Language.text = "한국어";
            Option_Vibration.text = "Vibration";
            Option_SoundEffect.text = "Sound Effect";
            Help.text = "Help";
        }
    }

    public void Sound_on_off()
    {
        if (buttonEvent.Sound == true)
        {
            startBGM.volume = 0;
            Sound_On.SetActive(false);
            Sound_Off.SetActive(true);
            buttonEvent.Sound = false;
        }
        else
        {
            startBGM.volume = 1;
            Sound_On.SetActive(true);
            Sound_Off.SetActive(false);
            buttonEvent.Sound = true;
        }
    }
}
