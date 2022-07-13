using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    int randommap;
    private float Xpos= 9+116;
    [SerializeField]GameObject a;
     [SerializeField]GameObject b;
      [SerializeField]GameObject c;
       [SerializeField]GameObject d;

  [SerializeField]GameObject mapImage; 
    void Start()
    {
        randommap=Random.Range(0,5);
        for(int i=0; i<3; i++)
        {
  BackGroundSpawn();
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BackGroundSpawn()
    {
        
        Vector3 vec = new Vector3(Xpos,-1,0);
        Instantiate(mapImage,vec,Quaternion.identity);
        Xpos+=116f;
         
    }
    void MapSpawn()
    {
    switch(randommap)
    {
        case 0 :
        Instantiate(a);
        break;
    }
      randommap=Random.Range(0,5);
    }
}
