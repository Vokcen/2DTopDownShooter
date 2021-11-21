using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWeapon : MonoBehaviour
{
  public Bullet bullet;

  private void OnTriggerEnter2D(Collider2D other) {
      if (other.gameObject.tag=="Bullet")
      { Debug.Log("kırmızı oldu");
          bullet.SelectedWeapon=WeaponTypes.Red;
      }
  }
}
