using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level1EnemyV2 : MonoBehaviour
{  
     float distance;
      [SerializeField]float enemySpeed;
      int hp=100;
      int damageAmaount;
      Transform playerPos;
      [SerializeField]Timer tim;
      [SerializeField]Bullet weaponColor;
     
    void Start()
    {
         playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        AIFollowCharacter();
    }
      void AIFollowCharacter()
    {
        distance = Vector2.Distance(transform.position, playerPos.position);
        transform.position =Vector2.MoveTowards(transform.position,playerPos.position,enemySpeed*Time.deltaTime);
    } 
    private void OnTriggerEnter2D(Collider2D other) {
       if (other.gameObject.tag=="Bullet")
       {if (weaponColor.SelectedWeapon==WeaponTypes.Green)
       {    tim.CurrentPoint++;
           gameObject.SetActive(false);
       }
           
       }
    }
       
    
}
