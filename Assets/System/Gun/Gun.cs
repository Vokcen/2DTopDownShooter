using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public  class Gun : MonoBehaviour
{



[SerializeField] Rigidbody2D rb; //Future needed.

Vector2 movement;  //Future needed for maybe movement
Vector2 mousePos;

    bool collide=false;
private void Update()
 {
              GetValueFromMouse();
    

    }
     private void FixedUpdate()
         {
  
    
     GunRotor();
     }


 
  void GetValueFromMouse()
    {
          movement.x=Input.GetAxisRaw("Horizontal");
          movement.y=Input.GetAxisRaw("Vertical");  
          mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    void GunRotor()
    {
         Vector2 lookDir=mousePos-rb.position;
   float angle=Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg-90f;


   rb.rotation=angle;
    }
    

}
