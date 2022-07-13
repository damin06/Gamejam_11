using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSceneLanguage : MonoBehaviour
{
    [SerializeField] Text Skin;
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
            Skin.text = "스킨";
            SkinHelpText1.text = "고양이를 누르면 고양이 스킨을 착용할 수 있습니다.";
            SkinHelpText2.text = "[뽑기]에서 고양이를 얻어 스킨을 적용할 수 있습니다.";
        }
        else
        {
            Skin.text = "Skin";
            SkinHelpText1.text = "You can get a cat from [Roulette] and apply a skin.";
            SkinHelpText2.text = "Tap on a cat to wear a cat skin.";
        }
    }
}
