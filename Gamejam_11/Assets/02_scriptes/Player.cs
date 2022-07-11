using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
       [SerializeField]private float speed;
     Vector3 vec = Vector3.right;
     float movementscale=24;
    // [SerializeField]Text te;
     Rigidbody2D rd;
     public static bool isGround=false;
        bool isrun=false;

    // Start is called before the first frame update
    void Start()
    {
       //Input.gyro.enabled =true;
         rd=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
// Vector3 adforce = new Vector3(0,0,Input.gyro.rotationRateUnbiased.z);
//           Vector3 force = Vector3.zero;
//           force.y = Vector3.Dot(Input.gyro.gravity, Vector3.up)* movementscale;
//          rd.AddForce(force);
//          //rd.AddForce(Vector3.forward*movementscale);
         //te.text=Input.gyro.gravity.ToString();         
         if(Input.GetMouseButtonDown(0))
         {
         // Destroy(gameObject);
          Debug.Log("아");
         }
           if (Input.GetMouseButton(0) && isGround)
       {
           transform.position+=vec*speed*Time.deltaTime;
                  Debug.Log("Pressed left click.");
       }

            if(Input.touchCount>0)
         {
          isrun=true;
         } 
         else
         {
          isrun=false;
         }  
         if(isrun)
         {
           transform.position+=vec*speed*Time.deltaTime;
         }
    }

    void FixedUpdate()
{
//rd.AddForce(Vector3.forward * movementscale);
    
	// float gx = Input.gyro.rotationRateUnbiased.x * 9.81f;
	// float gy = Input.gyro.rotationRateUnbiased.y * 9.81f;
     // float gz = Input.gyro.rotationRateUnbiased.z * 9.81f;
	// Physics2D.gravity = new Vector3(0, 0,gz);

}
private void OnCollisionEnter2D(Collision2D collision)
{
          Debug.Log("샌즈");
if(collision.gameObject.CompareTag("Ground"))
{
     Debug.Log("와우");
isGround=true;
}
else
{
     isGround=false;
}
}
private void OnTriggerExit2D(Collision2D collision)
{
      isGround=false;
}

}
