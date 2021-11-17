using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("detect");

       
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
