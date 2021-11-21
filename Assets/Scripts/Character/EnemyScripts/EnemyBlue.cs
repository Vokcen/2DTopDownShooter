using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Velat;
using UnityEngine.Experimental.Rendering.Universal;
using DG.Tweening;
using UnityEngine.UI;

public class EnemyBlue : MonoBehaviour
{  
   float hurtspeed=0.005f;
     float distance; 
   int hp=100;
   int damageAmaount;
  
   Transform playerPos;
    SpriteRenderer enemySprite;
    Light2D enemyLight;
    [SerializeField]float enemySpeed;
   [SerializeField] Image effectBar;
     [SerializeField] Image healthBar;
     [SerializeField]Bullet bullet;

 CharacterControl enemyBlue= new CharacterControl();  

    void Start()
    {
        enemySprite=GetComponent<SpriteRenderer>();
        enemyLight=GetComponentInChildren<Light2D>();
         playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        
        
        ////////////////Burda--------Kaldın//////////////////////

        
    }

    // Update is called once per frame
    void Update()
    {
      AIFollow();
      UIStuff();
    }
    void UIStuff()
    {
      enemyBlue.HealthPopup(effectBar,healthBar,hurtspeed);
   
    }
    void AIFollow()
    {
      
        distance = Vector2.Distance(transform.position, playerPos.position);
        transform.position =Vector2.MoveTowards(transform.position,playerPos.position,enemySpeed*Time.deltaTime);
    
    
    }
    
private void OnTriggerEnter2D(Collider2D other)
 {
     if (other.gameObject.tag == "Bullet")
        { if (bullet.SelectedWeapon==WeaponTypes.Blue)
        {
            
           
               Camera.main.DOShakePosition(0.5f,0.1f,10,90,true);

       
              enemyLight.intensity-=0.2f;
          other.gameObject.SetActive(false);
      
    
        
        damageAmaount=Random.Range(6,12);
         bool isCriticalHit=Random.Range(0,100)<30;
        
        
        
        
        if (isCriticalHit){
            damageAmaount*=2;
             Camera.main.DOShakePosition(0.5f,0.3f,10,90,true);
           
        }
            DamagePopup.Create(transform.position,damageAmaount,isCriticalHit);
               
             enemyBlue.EnemyDamage(damageAmaount);
          
            if (enemyBlue.GetHealth()<= 0)
           {
               gameObject.SetActive(false);
           }
     
         
              } 
        }
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("mavi düşman değdi sonradan eklenmeli");
        }   
}
}
