using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class  GameAssets : MonoBehaviour
{   
    private static GameAssets _i;
    public static GameAssets i{
        get{    
            if(_i==null)_i=Instantiate(Resources.Load("ReferanceManager")as GameObject).GetComponent<GameAssets>();
           return _i;
        }
    }
    

    public Transform pfDamagePopup;
    public SpriteRenderer enemyBlue;
    public Light2D _light; 
   
   
    
    }
    

