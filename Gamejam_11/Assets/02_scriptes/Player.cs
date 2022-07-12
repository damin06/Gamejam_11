using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
     float movementscale=1;
     [SerializeField]Text te;
     Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
         rd=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
          Vector3 force = Vector3.zero;
          force.y = Vector3.Dot(Input.gyro.gravity, Vector3.up)* movementscale;
         rd.AddForce(force);
         te.text=Input.gyro.gravity.ToString();                  
    }
}
