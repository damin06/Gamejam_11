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

       Transform parents; 
  [SerializeField]GameObject mapImage; 
  
  private float MAPXpos=40+93f;
    void Start()
    {
     
        parents= GameObject.Find("mapCONTROL").transform;
        randommap=Random.Range(0,1);
        for(int i=0; i<3; i++)
        {
  BackGroundSpawn();
        }
        MapSpawn();
        MapSpawn();
      
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
        ; 
        Vector3 vec= new Vector3(MAPXpos,0.2f,0);
    switch(randommap)
    {
        case 0 : 
            GameObject aClone=Instantiate(a,vec,Quaternion.identity) ;
            aClone.transform.parent= parents;
            MAPXpos+=93f;
            break;
    }
      randommap=Random.Range(0,1);
    }
}
