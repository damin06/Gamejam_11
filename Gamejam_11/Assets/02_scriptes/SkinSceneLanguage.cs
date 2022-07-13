using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSceneLanguage : MonoBehaviour
{
    [SerializeField] Text Back;
    [SerializeField] Text Skin;
    [SerializeField] Text Roulette;

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
        }
        else
        {
            Back.text = "Home";
            Skin.text = "Skin";
            Roulette.text = "Roulette";
        }
    }
}
