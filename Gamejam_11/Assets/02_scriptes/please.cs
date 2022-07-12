using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class please : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("아암암ㄴ어ㅏㅁㄴ엄나암ㅇ");
    }
     private void OnTriggerEnter(Collider other) 
     {  
        
    Debug.Log("와 샌즈!");
         if(other.CompareTag("Player"))
         {
              Destroy(gameObject);
            CoinManager.CoinCounter++;
              Debug.Log("와 샌즈!");
           
          
        }

     }   
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //        Debug.Log("와 샌즈!");
    //     if(collision.gameObject.CompareTag("Player"))
    //     {
    //          Debug.Log("와 샌즈!!!!!!!!");
    //         CoinManager.CoinCounter++;
    //          Destroy(gameObject);
    // }
    // }
}
