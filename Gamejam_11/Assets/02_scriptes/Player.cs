using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
 
       [SerializeField]private float speed;
     Vector3 vec = Vector3.right;
     float movementscale=24;

     Rigidbody2D rd;
       bool isGround=false;
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
  
       
     
    }

    void FixedUpdate()
{
         if (Input.GetMouseButton(0) && isGround)
       {
           transform.position+=vec*speed*Time.deltaTime;
                 // Debug.Log("Pressed left click.");
       }

            if(Input.touchCount>0 && isGround)
         {
      transform.position+=vec*speed*Time.deltaTime;
         } 
 
//rd.AddForce(Vector3.forward * movementscale);
    
	// float gx = Input.gyro.rotationRateUnbiased.x * 9.81f;
	// float gy = Input.gyro.rotationRateUnbiased.y * 9.81f;
     // float gz = Input.gyro.rotationRateUnbiased.z * 9.81f;
	// Physics2D.gravity = new Vector3(0, 0,gz);

}
private void OnCollisionEnter2D(Collision2D collision)
{
     // if(collision.gameObject.CompareTag("Mackerel"))
     // {
     //          Destroy(collision.gameObject);
     //      CoinManager.CoinCounter++;
     // }
         
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
private void OnCollisionExit2D(Collision2D collision)
{
      isGround=false;
}
// private void OnTrigerEnter2D(CircleCollider2D collision)
// {

//      Debug.Log("와 샌즈!");
//      if(collision.CompareTag("Mackerel"))
//      {
//           Debug.Log("와 샌즈!");
//                      Destroy(collision.gameObject);
//           CoinManager.CoinCounter++;
//      }
// }
//312-0176-0316-51 농협 고다민
}
