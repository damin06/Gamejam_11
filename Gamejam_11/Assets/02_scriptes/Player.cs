using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
     [SerializeField]Sprite JumpSprite;  
     [SerializeField]Sprite justcat;
     [SerializeField]Sprite catDie;
       [SerializeField]private float speed;
     Vector3 vec = Vector3.right;
     float movementscale=24;
     private float jumptime=1.8f;

     Rigidbody2D rd;
       bool isGround=false;
        bool isrun=false;
       SpriteRenderer spriteRen;
       bool islevitation=false;
       bool isDIe=false;
       public float jumpPower=8;
       bool ispushedRunButton=false;  
       bool ispushedFeatButton=false;
       private float CurrenTime=4;
      private Vector3 playerPos;
    void Start()
    {
        spriteRen=GetComponent<SpriteRenderer>();
       //Input.gyro.enabled =true;
         rd=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
  if(FEVER.IsFEVER)
  {
     FEVER.IsFEVER=!FEVER.IsFEVER;
     
  }
       if(isGround==false)
       {
          jumptime-=Time.deltaTime;
          if(jumptime<0 && ispushedFeatButton==false)
          {
          spriteRen.sprite=JumpSprite;
          islevitation=true;
          }
       }
       else if(ispushedRunButton==false && isGround && isDIe==false)
       {
          jumptime=1.8f;
         spriteRen.sprite=justcat;
          islevitation=false;
       }
     
    }
IEnumerator featCat()
{
     yield return null;
}
    void FixedUpdate()
{
  
  if(ispushedFeatButton)
  {
         
        CurrenTime+=Time.deltaTime;
   //transform.rotation *= Quaternion.Euler(Time.deltaTime * 0f, 0f, -360f);
   transform.Rotate(new Vector3(0,0,1)* 360 * Time.deltaTime);
     if(CurrenTime>4.7f && isDIe==false)
     {
          transform.rotation =Quaternion.Euler(0,0,0);
          CurrenTime=4;
          score.time+=10;
          ispushedFeatButton=false;
     }
  }
  
     if(isDIe)
     {
             transform.rotation =Quaternion.Euler(0,0,0);
     }

    if(ispushedRunButton)
    {
     if(isGround && isDIe==false)
     {
         transform.position+=vec*speed*Time.deltaTime;
     }

    }
     // if(Input.GetMouseButtonDown(0) && islevitation)
     // {
     //  Debug.Log("공중부양");
     // }
     //     if (Input.touchCount>0 || Input.GetMouseButton(0) && isGround)
     //   {
     //       transform.position+=vec*speed*Time.deltaTime;
     //             // Debug.Log("Pressed left click.");
     //   }

     //        if(Input.touchCount>0 && isGround)
     //     {
     //  transform.position+=vec*speed*Time.deltaTime;
     //     } 
 
//rd.AddForce(Vector3.forward * movementscale);
    
	// float gx = Input.gyro.rotationRateUnbiased.x * 9.81f;
	// float gy = Input.gyro.rotationRateUnbiased.y * 9.81f;
     // float gz = Input.gyro.rotationRateUnbiased.z * 9.81f;
	// Physics2D.gravity = new Vector3(0, 0,gz);

}
private void OnCollisionEnter2D(Collision2D collision)
{
        if(ispushedFeatButton && collision.gameObject.CompareTag("Ground"))
     {
          isDIe=true;
          Debug.Log("개못하네");
            spriteRen.sprite=catDie;
     }

         
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
private void OnCollisionStay2D(Collision2D collision)
{
  
    if(collision.gameObject.CompareTag("Ground"))
{
     Debug.Log("와우");
isGround=true;
}
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
public void JumpButton()
{
  if(isGround && isDIe == false)
      {
          rd.AddForce(Vector2.up* jumpPower , ForceMode2D.Impulse);
      }
}
public void RunButtonDown()
{
ispushedRunButton = true;
}
public void RunButtonPUSH()
{
     Debug.Log("우와");
     if(islevitation && CurrenTime>3 && isDIe == false)
     {
          Debug.Log("와아");
     spriteRen.sprite=justcat;  
     ispushedFeatButton=true;
     }
}
public void RunButtonUp()
{
     ispushedRunButton = false;
}

}
