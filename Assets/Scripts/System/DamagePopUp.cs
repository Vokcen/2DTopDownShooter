using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
     //Create Damage Popup in Create()
          public static DamagePopup Create(Vector3 position, int damageAmount,bool isCriticalHit) {
        Transform damagePopupTransform = Instantiate(GameAssets.i.pfDamagePopup, position, Quaternion.identity);

        DamagePopup damagePopup = damagePopupTransform.GetComponent<DamagePopup>();
        damagePopup.Setup(damageAmount,isCriticalHit);

        return damagePopup;
          }


private static int sortingOrder;
   private const float DESTROY_TIMER_MAX=1F;
     TextMeshPro textMesh;
    float destroyTime;
    Color textColor;  
 Vector3 moveVector;

     private void Awake() 
     {
        textMesh=transform.GetComponent<TextMeshPro>();
    }
  public  void  Setup(int damageAmount,bool isCriticalHit)
    {
             textMesh.SetText(damageAmount.ToString());
             if (!isCriticalHit)
             {
                  textMesh.fontSize=24;
                 textColor=Color.white;
             }
             else
             {
              textMesh.fontSize=36;
                textColor=Color.red;


             }
             textMesh.color=textColor;
             
             destroyTime=DESTROY_TIMER_MAX;

              sortingOrder++;
              textMesh.sortingOrder=sortingOrder;

             moveVector=new Vector3(0.7f,1)*30f;
    }
    private void Update()
     {
      
      transform.position+=moveVector*Time.deltaTime;
      moveVector-=moveVector*8f*Time.deltaTime;
     if (destroyTime>DESTROY_TIMER_MAX*0.5f)
     {  //First half of the popuplife
     float increaseScaleAmount=1f;
        transform.localScale+=Vector3.one*increaseScaleAmount*Time.deltaTime;
        
     }else
     { // second half of popuplife
         float decraseScaleAmount=1f;
                 transform.localScale-=Vector3.one*decraseScaleAmount*Time.deltaTime;

     }
      destroyTime-=Time.deltaTime;
      if (destroyTime<0)
      {float destroySpeed=9f;
      textColor.a-=destroySpeed*Time.deltaTime;
      textMesh.color=textColor;
      if (textColor.a<0)
      {
          Destroy(gameObject);
      }
          
      }
    }
    
}
