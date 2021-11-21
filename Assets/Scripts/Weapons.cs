using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
   public List<WeaponTyp> WeaponTyps;
}

[System.Serializable]
public class WeaponTyp
{
    public string WeaponName;
    public int damage;
    public TypeOfWeapon weaponTyp;
    public GameObject Prefab;
    public SpriteRenderer ItemSprite;

    public enum TypeOfWeapon{
        Green,
        Red,
        Blue
    }
}