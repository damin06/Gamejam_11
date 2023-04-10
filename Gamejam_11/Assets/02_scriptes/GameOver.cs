using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]GameObject player;
    [SerializeField]GameObject playerpos;
    [SerializeField]Image GameOver_Icon;
    [SerializeField]Image GameOver_MoneyImage;
    [SerializeField]Image GameOver_ScoreImage;
    [SerializeField]Image GameOver_Background;
    [SerializeField]Image GameOver_Pannel;
    [SerializeField]Button GameOver_UI;
    [SerializeField]Text scoreTXT;
    [SerializeField]Text moneyTXT;
    void Awakeart()
    {
        player.transform.position = playerpos.transform.position;
        gamererode();
    }   
void gamererode()
{
  //
}
    // Update is called once per frame
    void Update()
    {

        if(Player.isDIe ==true)
        {
            player.transform.position = playerpos.transform.position;
            Time.timeScale=0;   
            GamePause();
        }
    }
    private void GamePause()
    {
        GameOver_Icon.gameObject.SetActive(true);
        GameOver_MoneyImage.gameObject.SetActive(true);
        GameOver_ScoreImage.gameObject.SetActive(true);
        scoreTXT.gameObject.SetActive(true);
        moneyTXT.gameObject.SetActive(true);
        int nowscore = (int)score.time;
        float a = score.time / 10;
        int nowmoney = (int)a;
        PlayerPrefs.SetInt("score", nowscore);
        PlayerPrefs.SetInt("money",nowmoney);
        scoreTXT.text="  "+string.Format("{0:N0}", score.time);
        moneyTXT.text="  "+ string.Format("{0:N0}", a);
        GameOver_UI.gameObject.SetActive(true);
        GameOver_Pannel.gameObject.SetActive(true);
        GameOver_Background.gameObject.SetActive(true);
    }
    public void gohome()
    {
        Player.isDIe = false;
               Time.timeScale=1;   
           
                 //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Start");
     
    }
}
