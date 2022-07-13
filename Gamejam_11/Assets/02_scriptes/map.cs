using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    int randommap;
    private float Xpos=1428;
    [SerializeField]GameObject a;
     [SerializeField]GameObject b;
      [SerializeField]GameObject c;
       [SerializeField]GameObject d;

       Transform parents; 
  [SerializeField]GameObject mapImageA;
 [SerializeField]GameObject mapImageB;
  [SerializeField]GameObject mapImageC;
   [SerializeField]GameObject mapImageD;
  int randmomImage;
  private   float MAPXpos=1474;
    void Start()
    {
      randmomImage=Random.Range(0,4);
        parents= GameObject.Find("mapCONTROL").transform;
        randommap=Random.Range(0,3);
        for(int i=0; i<50; i++)
        {
  BackGroundSpawn();
        }
    for(int i=0; i<50; i++)
        {
  MapSpawn();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BackGroundSpawn()
    {
          
              Vector3 vec1 = new Vector3(Xpos,-135.03f,0);
        switch(randmomImage)
        {
            case 0 :
                Instantiate(mapImageA,vec1,Quaternion.identity);
                Xpos+=116.4f;
                break;
           case 1 : 
                Instantiate(mapImageC,vec1,Quaternion.identity);
                Xpos+=124.4f;
                break;
            case 2 :
                 Instantiate(mapImageB,vec1,Quaternion.identity);
                Xpos+=128;
                break;
                case 3 :
                     Instantiate(mapImageD,vec1,Quaternion.identity);
                Xpos+=117.8f;
                break;
        }

         
    }
    void MapSpawn()
    {
      
        Vector3 vec= new Vector3(MAPXpos,-121.83f,0);
    switch(randommap)
    {
        case 0 : 
            GameObject aClone=Instantiate(a,vec,Quaternion.identity) ;
           // aClone.transform.parent= parents;
            //aClone.transform.position=vec;
            //MAPXpos+=131;
            break;
        case 1 :
           GameObject bClone=Instantiate(b,vec,Quaternion.identity) ;
           // bClone.transform.parent= parents;
            //bClone.transform.position=vec;
            //MAPXpos+=131;
            break;
        case 2 :
           GameObject cClone=Instantiate(c,vec,Quaternion.identity) ;
           // cClone.transform.parent= parents;
          //  cClone.transform.position=vec;
            //MAPXpos+=131;
            break;
    }
         MAPXpos+=131;
      randommap=Random.Range(0,3);
    }
}
