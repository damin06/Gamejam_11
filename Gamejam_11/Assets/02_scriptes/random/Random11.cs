using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random11 : MonoBehaviour
{

    // Ȱ��ȭ,��Ȱ��ȭ �� ������Ʈ

    public GameObject DrawShop; // �̱� ����
    public GameObject DrawWindow; // �̴� â

    // �ҷ��� �̹��� ������Ʈ
    public Image DrawImage; // ���� �̹����� ����� ������Ʈ

    //���� �̹���
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    

    public GameObject Gi1;
    public GameObject Gi2;
    public GameObject Gi3;
    public GameObject Gi4;
    public GameObject Gi5;
    public GameObject Gi6;
    



    public Sprite Nomoney;

    public GameObject Result_PopUp;
    public GameObject Result_Btn;
    
    

    // ����
    public int RandomInt; // ���� ����



    void Update()
    {
       
       RandomInt = Random.Range(0, 10); // ���� ������ �����մϴ�.


    }

    public void OneDraw() // 1ȸ �̱� ��ư�� Ŭ�� ��
    {
        if (CoinManager.Coin >= 10)
        {
            CoinManager.Coin -= 10;

            DrawShop.SetActive(false); //�̱� ���� ȭ���� ��Ȱ��ȭ�ϰ�,
            DrawWindow.SetActive(true);// ���� �̹����� ����� ȭ���� Ȱ��ȭ�մϴ�.

            StartCoroutine("RandomOn");
        }
            
        

        
    }
    IEnumerator RandomOn()
    {
        for (int i = 0; i <= 5; i++)
        {
            DrawImage.sprite = Image1;
            yield return new WaitForSeconds(0.04f);
            DrawImage.sprite = Image2;
            yield return new WaitForSeconds(0.04f);
            DrawImage.sprite = Image3;
            yield return new WaitForSeconds(0.04f);
            DrawImage.sprite = Image4;
            yield return new WaitForSeconds(0.04f);
            DrawImage.sprite = Image5;
            yield return new WaitForSeconds(0.04f);
            DrawImage.sprite = Image6;
            yield return new WaitForSeconds(0.04f);
            
        }

        if (RandomInt == 1) // RandomInt�� 1�̶��
        {
            DrawImage.sprite = Image1;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);

            Gi1.SetActive(true);

        }
        else if (RandomInt == 2)
        {
            DrawImage.sprite = Image2;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);

            Gi2.SetActive(true);

        }
        else if (RandomInt == 3)
        {
            DrawImage.sprite = Image3;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);

            Gi3.SetActive(true);

        }
        else if (RandomInt == 4)
        {
            DrawImage.sprite = Image4;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);

            Gi4.SetActive(true);

        }
        else if (RandomInt == 5)
        {
            DrawImage.sprite = Image5;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);

            Gi5.SetActive(true);

        }
        else 
        {
            
            DrawImage.sprite = Image6;
            Debug.Log("??");
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);

            Gi6.SetActive(true);

        }
        
        Invoke("CloseDraw", 2f);


       

    }


    public void CloseDraw() // �̱� ��ũ��Ʈ�� ����ǰ� �ڵ����� ����ǰ� �մϴ�.
    {
        DrawImage.sprite = Nomoney; // �����ߴ� �̹����� �ʱ�ȭ�մϴ�.
        DrawShop.SetActive(true); // �̱� ���� ȭ���� Ȱ��ȭ �ϰ�,
        DrawWindow.SetActive(false); // ���� �̹��� ȭ���� ��Ȱ��ȭ�մϴ�
    }
}