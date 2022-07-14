using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSceneLanguage : MonoBehaviour
{
    [SerializeField] Text ok;
    [SerializeField] Text get;
    [SerializeField] Text catAllOk;
    [SerializeField] Text catAllText;

    private void Update()
    {
        if (GameControl.control.Language == false)
        {
            ok.text = "Ȯ��";
            get.text = "ȹ��"!;
            catAllOk.text = "Ȯ��";
            catAllText.text = "��� ����� ��Ų�� �� ������! ��ȣ!";
        }
        else
        {
            ok.text = "Ok";
            get.text = "Get!";
            catAllOk.text = "Ok";
            catAllText.text = "You got\nall cat skins!\nYeah!";
        }
    }
}
