using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using Velat;
public class GameManager : MonoBehaviour
{   [SerializeField]CharacterControl enemy;
int damage;
int health=100;
        void Start()
    {
        

enemy.GetHealth();
       
            enemy.EnemyHealth(health);
          Debug.Log(enemy.GetHealth());
           enemy.EnemyDamage(20);
          Debug.Log(enemy.GetHealth());
          enemy.EnemyDamage(20);
                    Debug.Log(enemy.GetHealth());

           

    }
   private void Update() 
   {
                    


   }


 
}
