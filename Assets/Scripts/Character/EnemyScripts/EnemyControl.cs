using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Experimental.Rendering.Universal;
using Velat;
using UnityEngine.UI;
public class EnemyControl : MonoBehaviour
{ 
    
    
    float distance;
   int hp=100;
   int damageAmaount;
   CharacterControl enemy=new CharacterControl();
   
[SerializeField]float hurtspeed;

  

 [SerializeField] SpriteRenderer sprite;
  public    Light2D eLight;
Transform playerPos;
   [SerializeField]float enemySpeed;
       

 [SerializeField]Image effectBar;
 [SerializeField]Image healthBar;

 
    private void OnEnable()
    {    
     
          
          eLight.color=Color.yellow;
          sprite.color=eLight.color;
          eLight.intensity=1f;
        
    }
    void Start()     
{  
    
     enemy.EnemyHealth(hp);
   
     
   
       

     
    playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      
     
    }

    void Update()
    {  
         AIFollowCharacter();
       
       UIStuff();
        
    }
 void UIStuff()

{
enemy.HealthPopup(effectBar,healthBar,hurtspeed);
}

    void AIFollowCharacter()
    {
        distance = Vector2.Distance(transform.position, playerPos.position);
        transform.position =Vector2.MoveTowards(transform.position,playerPos.position,enemySpeed*Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {  
        if (collision.gameObject.tag == "Bullet")
        {       
               Camera.main.DOShakePosition(0.5f,0.1f,10,90,true);

              eLight.color=Color.blue;
              sprite.color=eLight.color;
              eLight.intensity+=3f;
          collision.gameObject.SetActive(false);
      
    
        
        damageAmaount=Random.Range(6,12);
         bool isCriticalHit=Random.Range(0,100)<30;
        
        
        
        
        if (isCriticalHit){
            damageAmaount*=2;
             Camera.main.DOShakePosition(0.5f,0.3f,10,90,true);
           
        }
            DamagePopup.Create(transform.position,damageAmaount,isCriticalHit);
               
             enemy.EnemyDamage(damageAmaount);
          
            if (enemy.GetHealth()<= 0)
           {
               gameObject.SetActive(false);
           }
     
         

        }   
        
    }
}   
