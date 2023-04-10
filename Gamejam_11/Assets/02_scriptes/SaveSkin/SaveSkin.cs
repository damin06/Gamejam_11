using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class SkinJsonData
{
    //스킨을 가지고 있는지 없는지에 대한 bool값
    public string Name; //스킨의 이름
    public int Cost; //스킨의 가격
    public bool Having; //스킨 보유 여부
}

public class SaveSkin : MonoBehaviour
{
    int skinCount = 6; //현재 게임의 스킨 총 갯수

    private void Start()
    {
        SkinJsonData[] skinJsonData = new SkinJsonData[skinCount];
        #region 노랑 스킨(기본)
        skinJsonData[0] = new SkinJsonData();
        skinJsonData[0].Name = "노랑이";
        skinJsonData[0].Cost = 0;
        skinJsonData[0].Having = true;
        #endregion

        #region 삼색이
        skinJsonData[0] = new SkinJsonData();
        skinJsonData[0].Name = "삼색이";
        skinJsonData[0].Cost = 100;
        skinJsonData[0].Having = false;
        #endregion

    }
}
