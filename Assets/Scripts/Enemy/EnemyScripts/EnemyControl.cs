using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EnemyControl : MonoBehaviour
{ 
    public float shakeTime;
    public float shakePower;
    public CameraShake cam;
    float distance;
    [SerializeField] Base bs;
    [SerializeField] HealthBar enemyHb;

 [SerializeField] SpriteRenderer sprite;
Transform playerPos;
   [SerializeField]float enemySpeed;


    private void OnEnable()
    {
        enemyHb.hp = 100;
        sprite.color=Color.yellow;
        
    }
    void Start() 
{     
               
    playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
     
    }

    void Update()
    {   
         AIFollowCharacter();
        aiDamage();
    }


    void AIFollowCharacter()
    {
        distance = Vector2.Distance(transform.position, playerPos.position);
        transform.position =Vector2.MoveTowards(transform.position,playerPos.position,enemySpeed*Time.deltaTime);
    }
    void aiDamage()
    {
        if (enemyHb.hp<=20)
        {
          sprite.color=Color.red;
         


        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {    
               Camera.main.DOShakePosition(shakeTime,shakePower,10,90,true);

          
          collision.gameObject.SetActive(false);
      
      
        
        int damageAmount=Random.Range(100,200);
         bool isCriticalHit=Random.Range(0,100)<30;
        
        
        
        
        if (isCriticalHit){
            damageAmount*=2;
             Camera.main.DOShakePosition(0.5f,0.3f,10,90,true);
           
        }
            DamagePopup.Create(transform.position,damageAmount,isCriticalHit);
            enemyHb.hp -= 5;
            if (enemyHb.hp <= 0)
            {
                this.gameObject.SetActive(false);
            }

         

        }   
        if (collision.gameObject.tag == "Player")
        {
            bs.health += -1;
            collision.GetComponentInChildren<HealthBar>().hp -= 10;
            this.gameObject.SetActive(false);
        
        }
    }
}   
