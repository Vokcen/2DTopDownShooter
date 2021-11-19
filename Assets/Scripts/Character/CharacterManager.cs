using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
namespace Velat{
public abstract class CharacterManager : MonoBehaviour
{  
   int _health;
   int _maxHealth;
  
   int _damage;
  
          public int maxHealth { get => _maxHealth; set => _maxHealth = value; }
          public int health { get => _health; set => _health = value; }

          public int damage { get => _damage; set => _damage = value; }

         
      
  public abstract void EnemyColor(Color enemyColor,Light2D enemyLight);
   public abstract void EnemyHealth(int MaxHealth);
  public abstract void EnemyDamage(int damageAmaount);
  public abstract void EnemyMove(Vector3 move);
    public abstract int GetHealth();
 
    public abstract float GetHealthPercent();
    public abstract void HealthPopup(Image effectBar,Image healthBar,float hurtSpeed);
    

}}


