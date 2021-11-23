using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Velat;
using UnityEngine.Experimental.Rendering.Universal;
using DG.Tweening;

public class CharacterLevel2 : MonoBehaviour
{

    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Movement();
    }
    void Movement()
    {     float x=Input.GetAxis("Horizontal")*Time.deltaTime*Speed;
           float y=Input.GetAxis("Vertical")*Time.deltaTime*Speed;
        transform.position+=new Vector3(x,y,0);
   
   if (Input.GetKeyDown(KeyCode.Space))
   {
              transform.DOPunchPosition(-transform.up,0.1f,1);

   }
   if (Input.GetKeyDown(KeyCode.E))
   {
              transform.DOSmoothRewind();

   }
     
    }
}
