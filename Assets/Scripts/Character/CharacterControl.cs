using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;

namespace Velat{
    public class CharacterControl : CharacterManager
    {
    
    
        
    
         
         public override void  Weapon(WeaponType state)
         {
             if (state==WeaponType.Green)
             {
                 ChoseWeapon=WeaponType.Green;
             }
             else if (state==WeaponType.Red)
             {
                 ChoseWeapon=WeaponType.Red;

             }
             else if (state==WeaponType.Blue)
             {
                 ChoseWeapon=WeaponType.Blue;
             }
         }
      
        public override void EnemyColor(Color enemyColor, Light2D enemyLight)
        { 
           enemyLight.color=enemyColor;
           
        }

        public override void EnemyDamage(int damageAmaount)
        {
             health-=damageAmaount;
         if (health<0)health=0;
           
        }

        public override void EnemyHealth(int MaxHealth)
        { maxHealth=MaxHealth;
            health=MaxHealth;
              
        }
        public override float GetHealthPercent()
        {

            return(float) health/maxHealth;
        }

        
        public override int GetHealth()
        { 
             return  health;
        }
        
        public override void HealthPopup(Image effectBar,Image healthBar,float hurtSpeed)
        {
             healthBar.fillAmount =GetHealthPercent();
        if (effectBar.fillAmount>healthBar.fillAmount)
        {
            effectBar.fillAmount -= hurtSpeed;
        }
        else
        {
            effectBar.fillAmount = healthBar.fillAmount;
        }
        }

       
    }
    
}