using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mackerel : MonoBehaviour
{
    private void update()
    {
        
        Debug.Log("살려줘");
    }
    private void OnTrigerEnter2D(Collider2D collision)
    {

        Debug.Log("와 샌즈!");
        if(collision.CompareTag("Player"))
        {
             Debug.Log("와 샌즈!");
            CoinManager.CoinCounter++;
             Destroy(gameObject);
         }
    }   

}
