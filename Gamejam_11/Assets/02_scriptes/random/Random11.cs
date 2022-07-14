using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Random11 : MonoBehaviour
{
    // public
    AudioSource audioSource;
    AudioSource audioSource2;


    // Ȱ��ȭ,��Ȱ��ȭ �� ������Ʈ
    private float currenttime=3;

    public GameObject DrawShop; // �̱� ����
    public GameObject DrawWindow; // �̴� â

    
    // �ҷ��� �̹��� ������Ʈ
    public Image DrawImage; // ���� �̹����� ����� ������Ʈ
    public RectTransform DrawImageRT; // ���� �̹��� ����� ������Ʈ ��Ʈ Ʈ������


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
    
    
    public Sprite RanCats;

    public GameObject Result_PopUp;
    public GameObject Result_Btn;
    public GameObject Result_Text;

    public GameObject ExitButton;

    public GameObject skinAll;
    public GameObject skinAllBackGround;

    // ����
    public int RandomInt; // ���� ����

    private void Start()
    {
        audioSource = GameObject.Find("CelebrationSound").GetComponent<AudioSource>();
        audioSource2 = GameObject.Find("LingingSound").GetComponent<AudioSource>();
    }

    void Update()
    {
        RandomInt = Random.Range(0, 5);
        currenttime += Time.deltaTime;
    }

    public void OneDraw() // 1ȸ �̱� ��ư�� Ŭ�� ��
    {
        DrawImageRT.sizeDelta = new Vector2(400, 400); //������ ������ ����
        if (currenttime > 1.3f)
        {
            if (GameControl.control.coin >= 100 && GachaList.Count != 0)
            {
                ExitButton.SetActive(false);

                GameControl.control.coin -= 100;

                DrawShop.SetActive(false); //�̱� ���� ȭ���� ��Ȱ��ȭ�ϰ�,
                DrawWindow.SetActive(true);// ���� �̹����� ����� ȭ���� Ȱ��ȭ�մϴ�.

                StartCoroutine("Audio");

                StartCoroutine("RandomOn");

                //Gacha();
            }

            if (GachaList.Count == 0)
            {
                skinAll.SetActive(true);
                skinAllBackGround.SetActive(true);
            }
        }
    }

    public void skinAllNo()
    {
        skinAll.SetActive(false);
        skinAllBackGround.SetActive(false);
    }

    IEnumerator Audio()
    {
        audioSource2.Play();
        yield return new WaitForSeconds(1.0f);
        audioSource2.Play();
        yield return new WaitForSeconds(1.0f);
        audioSource2.Play();
    }

    IEnumerator RandomOn()
    {
        currenttime = 0;

        for (int i = 0; i <= 7; i++)
        {
            DrawImage.sprite = Image1;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image2;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image3;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image4;
            yield return new WaitForSeconds(0.1f);

            DrawImage.sprite = Image5;
        }

        Gacha();
    }

    public List<string> GachaList = new List<string>() { "cat2", "cat3", "cat4", "cat5", "cat6" };

    public void Gacha()
    {
        int rand = Random.Range(0, GachaList.Count);

        if (GachaList[rand] == "cat5") // RandomInt�� 1�̶��
        {
                audioSource.Play();

                DrawImage.sprite = Image1;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat5 = true;

                Gi1.SetActive(true);

            GachaList.RemoveAt(rand);
        }
        else if (GachaList[rand] == "cat4")
        {
                audioSource.Play();

                DrawImage.sprite = Image2;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat4 = true;

                Gi2.SetActive(true);

            GachaList.RemoveAt(rand);
        }
        else if (GachaList[rand] == "cat3")
        {
                audioSource.Play();

                DrawImage.sprite = Image3;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat3 = true;

                Gi3.SetActive(true);

            GachaList.RemoveAt(rand);
        }
        else if (GachaList[rand] == "cat2")
        {
                audioSource.Play();

                DrawImage.sprite = Image4;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat2 = true;

                Gi4.SetActive(true);

            GachaList.RemoveAt(rand);
        }
        else
        {
                audioSource.Play();

                DrawImage.sprite = Image5;
                Result_PopUp.SetActive(true);
                Result_Btn.SetActive(true);
                Result_Text.SetActive(true);
                ExitButton.SetActive(true);

                SkinChoose.skin.Cat6 = true;

                Gi5.SetActive(true);

            GachaList.RemoveAt(rand);
        }

        DrawImageRT.sizeDelta = new Vector2(400, 400); //��� ������ ������ ����

        Invoke("CloseDraw", 0.0f);
    }

    public void CloseDraw() // �̱� ��ũ��Ʈ�� ����ǰ� �ڵ����� ����ǰ� �մϴ�.
    {
        DrawImage.sprite = RanCats; // �����ߴ� �̹����� �ʱ�ȭ�մϴ�.
        DrawShop.SetActive(true); // �̱� ���� ȭ���� Ȱ��ȭ �ϰ�,
        DrawWindow.SetActive(false); // ���� �̹��� ȭ���� ��Ȱ��ȭ�մϴ�
    }
}