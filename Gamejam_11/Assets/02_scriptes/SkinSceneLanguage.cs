using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSceneLanguage : MonoBehaviour
{
    [SerializeField] Text Back;
    [SerializeField] Text Skin;
    [SerializeField] Text Roulette;
    [SerializeField] Text SkinHelpText1;
    [SerializeField] Text SkinHelpText2;

    ButtonEvent buttonEvent;

    // Start is called before the first frame update
    void Start()
    {
        buttonEvent = FindObjectOfType<ButtonEvent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.control.Language == false)
        {
            Back.text = "���Ʊ��";
            Skin.text = "��Ų";
            Roulette.text = "�귿";
            SkinHelpText1.text = "����̸� ������ ����� ��Ų�� ������ �� �ֽ��ϴ�.";
            SkinHelpText2.text = "[�̱�]���� ����̸� ��� ��Ų�� ������ �� �ֽ��ϴ�.";
        }
        else
        {
            Back.text = "Home";
            Skin.text = "Skin";
            Roulette.text = "Roulette";
            SkinHelpText1.text = "You can get a cat from [Roulette] and apply a skin.";
            SkinHelpText2.text = "Tap on a cat to wear a cat skin.";
        }
    }
}
