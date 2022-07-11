using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
    }
    void Update()
    {
        float a=Input.gyro.rotationRateUnbiased.z+1;
 Vector3 ve =new Vector3(0,0,a);
 
        transform.Rotate (ve);
        //transform.Rotate+=ve*Time.deltaTime;
    }
}
