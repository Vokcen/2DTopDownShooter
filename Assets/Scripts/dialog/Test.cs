using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Test : MonoBehaviour
{
  
    private void Start()
    {
      //DamagePopup.Create(Vector3.zero,100);

    }



    // Update is called once per frame
    void Update()
    { 
         Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);//mouse worldposition code 
           Vector2 mousePos = new Vector2(worldPoint.x, worldPoint.y);// 
    if (Input.GetMouseButtonDown(0))
    {   
    }
    }
}
