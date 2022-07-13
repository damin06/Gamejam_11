using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random11 : MonoBehaviour
{

    // 활성화,비활성화 할 오브젝트

    public GameObject DrawShop; // 뽑기 상점
    public GameObject DrawWindow; // 뽑는 창

    // 불러올 이미지 오브젝트
    public Image DrawImage; // 랜덤 이미지를 출력할 오브젝트

    //숫자 이미지
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
    
    

    // 변수
    public int RandomInt; // 랜덤 변수



    void Update()
    {
       
       RandomInt = Random.Range(0, 10); // 랜덤 범위를 설정합니다.


    }

    public void OneDraw() // 1회 뽑기 버튼을 클릭 시
    {
        if (CoinManager.Coin >= 10)
        {
            CoinManager.Coin -= 10;

            DrawShop.SetActive(false); //뽑기 선택 화면을 비활성화하고,
            DrawWindow.SetActive(true);// 랜덤 이미지를 출력한 화면을 활성화합니다.

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

        if (RandomInt == 1) // RandomInt가 1이라면
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


    public void CloseDraw() // 뽑기 스크립트가 실행되고 자동으로 실행되게 합니다.
    {
        DrawImage.sprite = Nomoney; // 적용했던 이미지를 초기화합니다.
        DrawShop.SetActive(true); // 뽑기 선택 화면을 활성화 하고,
        DrawWindow.SetActive(false); // 랜덤 이미지 화면을 비활성화합니다
    }
}