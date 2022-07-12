using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
  public static int CoinCounter;
 [SerializeField]Text coinTxt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinTxt.text="Coin: "+CoinCounter;
    }

}
