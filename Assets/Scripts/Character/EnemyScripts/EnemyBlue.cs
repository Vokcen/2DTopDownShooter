using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Velat;
using UnityEngine.Experimental.Rendering.Universal;
using DG.Tweening;

public class EnemyBlue : MonoBehaviour
{
     float distance;
   int hp=100;
   int damageAmaount;
   float hurtspeed=0.005f;
  SpriteRenderer enemySprite;
  Light2D enemyLight;

 CharacterControl enemyBlue=new CharacterControl();

    void Start()
    {

      enemySprite=GameAssets.i.enemyBlue;
       enemyLight=GetComponentInChildren<Light2D>();
        
        enemySprite.color=Color.gray;
        enemyLight.color=Color.gray;
        ////////////////Burda--------Kaldın//////////////////////

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
