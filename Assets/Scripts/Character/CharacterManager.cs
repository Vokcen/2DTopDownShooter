using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
namespace Velat{
public enum WeaponType
   { 
       Green,
       Red,
       Blue
       
 
}
  
[SerializeField]
public abstract class CharacterManager : MonoBehaviour
{  


  public WeaponType ChoseWeapon;
   int _health;
   int _maxHealth;
  
   int _damage;
   float speed;
  
          public int maxHealth { get => _maxHealth; set => _maxHealth = value; }
          public int health { get => _health; set => _health = value; }

          public int damage { get => _damage; set => _damage = value; }
   
        public float Speed { get => speed; set => speed = value; }


 public abstract void Weapon(WeaponType state);
        public abstract void EnemyColor(Color enemyColor,Light2D enemyLight);
   public abstract void EnemyHealth(int MaxHealth);
  public abstract void EnemyDamage(int damageAmaount);

    public abstract int GetHealth();
 
    public abstract float GetHealthPercent();
    public abstract void HealthPopup(Image effectBar,Image healthBar,float hurtSpeed);
  
 

}}


