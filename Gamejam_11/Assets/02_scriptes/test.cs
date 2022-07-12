using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
   [SerializeField]Text be;
    void Start()
    {
       
        Input.gyro.enabled =true;
    }
    void Update()
    {
        be.text=Input.gyro.rotationRateUnbiased.ToString();
        transform.Rotate (0,0,Input.gyro.rotationRateUnbiased.z*4.1f);
    }
}
