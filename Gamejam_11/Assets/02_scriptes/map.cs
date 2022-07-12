using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour
{
    private float Xpos= 9+116;
  [SerializeField]GameObject mapImage; 
    void Start()
    {
        for(int i=0; i<3; i++)
        {
  mapspawn();
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void mapspawn()
    {
        
        Vector3 vec = new Vector3(Xpos,-1,0);
        Instantiate(mapImage,vec,Quaternion.identity);
        Xpos+=116f;
         
    }
}
