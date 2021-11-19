using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Velat;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.Universal;
using DG.Tweening;


public class Character : MonoBehaviour
{
      int hp=100;
      int damage;
      float hurtspeed=0.005f;
bool isCriticalHit;
      [SerializeField]Image effectBar;
      [SerializeField]Image healthBar;

    CharacterControl character = new CharacterControl();
    void Start()
    {
        character.EnemyHealth(hp);
        
    }

    // Update is called once per frame
    void Update()
    {
        UIStuff();
        
    }
    void UIStuff()
    {
        character.HealthPopup(effectBar,healthBar,hurtspeed);     
    }
      private void OnTriggerEnter2D(Collider2D other)
       {
          if (other.gameObject.tag=="EnemyYellow")
          {
            other.gameObject.SetActive(false);//Gelecekte Değiştirilmeli şuan için test amaçlı.
          damage=Random.Range(6,12);
          isCriticalHit=Random.Range(0,100)<30;
          if (isCriticalHit)damage*=2;
        
              
           DamagePopup.Create(transform.position,damage,isCriticalHit);

           character.EnemyDamage(damage);
           if (character.GetHealth()<=0)
           {
               gameObject.SetActive(false);
           }
            }
      }
}
