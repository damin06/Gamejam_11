using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    int randommap;
    public static float Xpos=1428;
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
  public static float limitMinMapPos=1370;
    void Start()
    {
      randmomImage=Random.Range(0,4);
        parents= GameObject.Find("mapCONTROL").transform;
        randommap=Random.Range(0,3);
        for(int i=0; i<3; i++)
        {
  BackGroundSpawn();
        }
    for(int i=0; i<3; i++)
        {
  MapSpawn();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void BackGroundSpawn()
    {
          
              Vector3 vec1 = new Vector3(Xpos,-135.03f,0);
        switch(randmomImage)
        {
            case 0 :
           gameObject.transform.position=new Vector3(Xpos-116.4f,-135.03f,0);
               GameObject clonA= Instantiate(mapImageA,vec1,Quaternion.identity);
                Xpos+=116.4f;
               // clonA.transform.parent= parents;
                limitMinMapPos+=116.4f;
                break;
           case 1 : 
                   gameObject.transform.position=new Vector3(Xpos-124.4f,-135.03f,0);
                GameObject clonC= Instantiate(mapImageC,vec1,Quaternion.identity);
                Xpos+=123;
                //clonC.transform.parent= parents;
                limitMinMapPos+=123;
                break;
            case 2 :
                    gameObject.transform.position=new Vector3(Xpos-128,-135.03f,0);
               GameObject clonB =  Instantiate(mapImageB,vec1,Quaternion.identity);
                Xpos+=128;
                limitMinMapPos+=128;
                   //       clonB.transform.parent= parents;
                break;
                case 3 :
                        gameObject.transform.position=new Vector3(Xpos-117.8f,-135.03f,0);
                 GameObject clonD = Instantiate(mapImageD,vec1,Quaternion.identity);
                Xpos+=117.8f;
                limitMinMapPos+=-117.8f;
                     //     clonD.transform.parent= parents;
                break;
        }
    
    }
    public void MapSpawn()
    {
      
        Vector3 vec= new Vector3(MAPXpos,-134.6f,0);
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
          private void OnTriggerEnter2D(Collider2D other) 
     {  
        
    Debug.Log("아 제발");
         if(other.CompareTag("Player"))
         {
            BackGroundSpawn();
            MapSpawn();
            BackGroundSpawn();
            MapSpawn();
        }
     }   
}
