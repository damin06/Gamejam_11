using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FEVER : MonoBehaviour
{
    public static bool F= false;
    public static bool E = false;
    public static bool V= false;
    public static bool E2 = false;
    public static bool R = false;
    public static bool IsFEVER = false;
    private float FEVERTIME=10;
    private float CurrenTime=10;
    [SerializeField]Slider FEVERSLIDER;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if(F && E && V && E2 && R)
        {
            IsFEVER = true;
        }
              
            
        if(IsFEVER)
        {   
            
                CurrenTime-=Time.deltaTime;  
                  FEVERSLIDER.value= CurrenTime / FEVERTIME;
            FEVERSLIDER.gameObject.SetActive(true);
      
            if(CurrenTime<0)
            {
                IsFEVER=false;
                F=false;
                E=false;
                V=false;
                E2=false;
                R=false;
                FEVERSLIDER.gameObject.SetActive(false);
            }
        }
    }
}
