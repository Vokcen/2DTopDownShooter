using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopUp : MonoBehaviour
{
 

      
    private TextMeshPro textMesh;
 

     private void Awake() 
     {
        textMesh=transform.GetComponent<TextMeshPro>();
    }
    void  Setup(int damageAmount)
    {
             textMesh.SetText(damageAmount.ToString());
    }
     void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
