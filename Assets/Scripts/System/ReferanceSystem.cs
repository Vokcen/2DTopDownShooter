using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  ReferanceSystem : MonoBehaviour
{   
    private static ReferanceSystem _r;
    public static ReferanceSystem r{
        get{    
            if(_r==null)_r=(Instantiate(Resources.Load("ReferanceSystem"))as GameObject).GetComponent<ReferanceSystem>();
           return _r;
        }
    }

    
    
    }
    

