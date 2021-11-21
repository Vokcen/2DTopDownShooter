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
   [SerializeField]Bullet weaponty;

[SerializeField]float hurtspeed;

  

 SpriteRenderer sprite;
      Light2D eLight;
Transform playerPos;
   [SerializeField]float enemySpeed;
       

 [SerializeField]Image effectBar;
 [SerializeField]Image healthBar;

 
    private void OnEnable()
    {     enemy.EnemyHealth(hp);
     
          
          eLight.color=Color.yellow;
          sprite.color=eLight.color;
          eLight.intensity=1f;
        
    }
     private void Awake() {
         sprite=GetComponent<SpriteRenderer>();
    eLight=GetComponentInChildren<Light2D>();    
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
          if (weaponty.SelectedWeapon==WeaponTypes.Red)
     
      

               Camera.main.DOShakePosition(0.5f,0.1f,10,90,true);

       
              eLight.intensity-=0.2f;
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
            if (collision.gameObject.tag=="Player")
            {
                Debug.Log("Yeşil düşman hasar vermeli!!");
            }
     
         

        }   
        
    }

