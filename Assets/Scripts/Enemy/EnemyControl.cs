using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{

    float distance;
    [SerializeField] Base bs;
     


Transform playerPos;
   [SerializeField]float enemySpeed;

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
        if (distance <= 3)
        {
            bs.health += -1;
            this.gameObject.SetActive(false);
           


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Bullet")
        {
            this.gameObject.SetActive(false);
        }
    }
}   
