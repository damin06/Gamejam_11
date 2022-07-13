using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random11 : MonoBehaviour
{
    // public
    AudioSource audioSource;


    // 활성화,비활성화 할 오브젝트
    private float currenttime=3;

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
    
   

    public GameObject Gi1;
    public GameObject Gi2;
    public GameObject Gi3;
    public GameObject Gi4;
    public GameObject Gi5;
    
    



    public Sprite Nomoney;

    public GameObject Result_PopUp;
    public GameObject Result_Btn;
    public GameObject Result_Text;



    // 변수
    public int RandomInt; // 랜덤 변수
    private void Awake()
    {
        audioSource = GameObject.Find("Celebration").GetComponent<AudioSource>();
    }



    void Update()
    {
        RandomInt = Random.Range(0, 10); // 랜덤 범위를 설정합니다.
        currenttime += Time.deltaTime;

    }

    public void OneDraw() // 1회 뽑기 버튼을 클릭 시
    {
        if (currenttime > 1.3f)
        {
            if (CoinManager.Coin >= 10)
            {
                CoinManager.Coin -= 10;

                DrawShop.SetActive(false); //뽑기 선택 화면을 비활성화하고,
                DrawWindow.SetActive(true);// 랜덤 이미지를 출력한 화면을 활성화합니다.

                StartCoroutine("RandomOn");
                
            }

        }

        
    }
    IEnumerator RandomOn()
    {
        currenttime = 0;
        for (int i = 0; i <= 7; i++)
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
            
            
        }

        if (RandomInt == 1) // RandomInt가 1이라면
        {
            audioSource.Play();

            DrawImage.sprite = Image1;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);
            Result_Text.SetActive(true);

            Gi1.SetActive(true);

        }
        else if (RandomInt == 2)
        {
            audioSource.Play();

            DrawImage.sprite = Image2;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);
            Result_Text.SetActive(true);

            Gi2.SetActive(true);

        }
        else if (RandomInt == 3)
        {
            audioSource.Play();

            DrawImage.sprite = Image3;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);
            Result_Text.SetActive(true);

            Gi3.SetActive(true);

        }
        else if (RandomInt == 4)
        {
            audioSource.Play();

            DrawImage.sprite = Image4;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);
            Result_Text.SetActive(true);

            Gi4.SetActive(true);

        }
        else
        {
            audioSource.Play();

            DrawImage.sprite = Image5;
            Result_PopUp.SetActive(true);
            Result_Btn.SetActive(true);
            Result_Text.SetActive(true);

            Gi5.SetActive(true);

        }
        
        
        Invoke("CloseDraw", 1f);


       

    }


    public void CloseDraw() // 뽑기 스크립트가 실행되고 자동으로 실행되게 합니다.
    {
        DrawImage.sprite = Nomoney; // 적용했던 이미지를 초기화합니다.
        DrawShop.SetActive(true); // 뽑기 선택 화면을 활성화 하고,
        DrawWindow.SetActive(false); // 랜덤 이미지 화면을 비활성화합니다
    }
}