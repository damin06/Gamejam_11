using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSceneLanguage : MonoBehaviour
{
    [SerializeField] Text Skin;
    [SerializeField] Text SkinHelp;
    [SerializeField] Text SkinHelpText1;
    [SerializeField] Text SkinHelpText2;

    // Update is called once per frame
    void Update()
    {
        if (GameControl.control.Language == false)
        {
            Skin.text = "��Ų";
            SkinHelp.text = "����";
            SkinHelpText1.text = "����̸� ������ ����� ��Ų�� ������ �� �ֽ��ϴ�.";
            SkinHelpText2.text = "[�̱�]���� ����̸� ��� ��Ų�� ������ �� �ֽ��ϴ�.";
        }
        else
        {
            Skin.text = "Skin";
            SkinHelp.text = "Help";
            SkinHelpText1.text = "You can get a cat from [Roulette] and apply a skin.";
            SkinHelpText2.text = "Tap on a cat to wear a cat skin.";
        }
    }
}
