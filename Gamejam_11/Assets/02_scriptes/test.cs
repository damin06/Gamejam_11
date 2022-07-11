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
 
        transform.Rotate (0,0,Input.gyro.rotationRateUnbiased.z);
    }
}
