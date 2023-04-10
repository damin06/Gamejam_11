using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class SkinJsonData
{
    //��Ų�� ������ �ִ��� �������� ���� bool��
    public string Name; //��Ų�� �̸�
    public int Cost; //��Ų�� ����
    public bool Having; //��Ų ���� ����
}

public class SaveSkin : MonoBehaviour
{
    int skinCount = 6; //���� ������ ��Ų �� ����

    private void Start()
    {
        SkinJsonData[] skinJsonData = new SkinJsonData[skinCount];
        #region ��� ��Ų(�⺻)
        skinJsonData[0] = new SkinJsonData();
        skinJsonData[0].Name = "�����";
        skinJsonData[0].Cost = 0;
        skinJsonData[0].Having = true;
        #endregion

        #region �����
        skinJsonData[0] = new SkinJsonData();
        skinJsonData[0].Name = "�����";
        skinJsonData[0].Cost = 100;
        skinJsonData[0].Having = false;
        #endregion

    }
}
