using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts_exit : MonoBehaviour
{
    public GameObject Result_PopUp;
    public GameObject Result_Btn;

    public GameObject Gi1;
    public GameObject Gi2;
    public GameObject Gi3;
    public GameObject Gi4;
    public GameObject Gi5;
    public GameObject Gi6;
    public GameObject Gi7;
    public GameObject Gi8;
    public GameObject Gi9;
    public GameObject Gi10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void result()
    {
        Result_PopUp.SetActive(false);
        Result_Btn.SetActive(false);

        Gi1.SetActive(false);
        Gi2.SetActive(false);
        Gi3.SetActive(false);
        Gi4.SetActive(false);
        Gi5.SetActive(false);
        Gi6.SetActive(false);
        Gi7.SetActive(false);
        Gi8.SetActive(false);
        Gi9.SetActive(false);
        Gi10.SetActive(false);
    }
}
