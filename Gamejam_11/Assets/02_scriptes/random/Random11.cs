using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random11 : MonoBehaviour
{
    // public
    AudioSource audioSource;


    // Ȱ��ȭ,��Ȱ��ȭ �� ������Ʈ
    private float currenttime=3;

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
    
   

    public GameObject Gi1;
    public GameObject Gi2;
    public GameObject Gi3;
    public GameObject Gi4;
    public GameObject Gi5;
    
    



    public Sprite Nomoney;

    public GameObject Result_PopUp;
    public GameObject Result_Btn;
    public GameObject Result_Text;



    // ����
    public int RandomInt; // ���� ����
    private void Awake()
    {
        audioSource = GameObject.Find("Celebration").GetComponent<AudioSource>();
    }



    void Update()
    {
        RandomInt = Random.Range(0, 10); // ���� ������ �����մϴ�.
        currenttime += Time.deltaTime;

    }

    public void OneDraw() // 1ȸ �̱� ��ư�� Ŭ�� ��
    {
        if (currenttime > 1.3f)
        {
            if (CoinManager.Coin >= 10)
            {
                CoinManager.Coin -= 10;

                DrawShop.SetActive(false); //�̱� ���� ȭ���� ��Ȱ��ȭ�ϰ�,
                DrawWindow.SetActive(true);// ���� �̹����� ����� ȭ���� Ȱ��ȭ�մϴ�.

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

        if (RandomInt == 1) // RandomInt�� 1�̶��
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


    public void CloseDraw() // �̱� ��ũ��Ʈ�� ����ǰ� �ڵ����� ����ǰ� �մϴ�.
    {
        DrawImage.sprite = Nomoney; // �����ߴ� �̹����� �ʱ�ȭ�մϴ�.
        DrawShop.SetActive(true); // �̱� ���� ȭ���� Ȱ��ȭ �ϰ�,
        DrawWindow.SetActive(false); // ���� �̹��� ȭ���� ��Ȱ��ȭ�մϴ�
    }
}