using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static int Coin;
    [SerializeField] Text coincounter;
    // Start is called before the first frame update
    private void Awake()
    {
        Coin = 100;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coincounter.text = "       " + Coin;
    }
}
