using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    public bool click = false;
    public GameObject Option;
    public GameObject OptionTool;

    public AudioBehaviour StartBGM;


    ButtonEvent buttonEvent;
    [SerializeField] Text Exit;
    [SerializeField] Text ExitNo;
    [SerializeField] Text ExitYes;
    [SerializeField] Text OptionText;
    [SerializeField] Text Option_Language;
    [SerializeField] Text Option_Vibration;
    [SerializeField] Text Option_Sound;
    [SerializeField] Text Option_SoundEffect;

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
    }

    public void Language_Change()
    {
        if (buttonEvent.Language == false)
        {
            Exit.text = "정말 나가실건가요?";
            ExitNo.text = "아니요";
            ExitYes.text = "네";
            OptionText.text = "설정";
            Option_Language.text = "English";
            Option_Vibration.text = "진동";
            Option_Sound.text = "배경음";
            Option_SoundEffect.text = "효과음";
            buttonEvent.Language = true;
        }
        else
        {
            Exit.text = "Are you really going out?";
            ExitNo.text = "No";
            ExitYes.text = "Yes";
            OptionText.text = "Option";
            Option_Language.text = "한국어";
            Option_Vibration.text = "Vibration";
            Option_Sound.text = "Sound";
            Option_SoundEffect.text = "Sound Effect";
            buttonEvent.Language = false;
        }
    }

    public void Sound_on_off()
    {
        if (buttonEvent.Sound == false)
        {
            buttonEvent.Sound = true;
        }
        else
        {
            buttonEvent.Sound = false;
        }
    }
}
