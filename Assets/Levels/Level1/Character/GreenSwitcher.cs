using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class GreenSwitcher : MonoBehaviour
{
public SpriteRenderer sprite;
public SpriteRenderer bSprite;
public Light2D cLight;
public Light2D bLight;
   
public Bullet choseWeapon;
   private void OnTriggerEnter2D(Collider2D other) {
       if (other.gameObject.tag=="Bullet")
       {
           sprite.color=Color.green;
           bSprite.color=Color.green;
           cLight.color=Color.green;
           bLight.color=Color.green;
           choseWeapon.SelectedWeapon=WeaponTypes.Green;

       }
   }
}
