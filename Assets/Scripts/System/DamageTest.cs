using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTest : MonoBehaviour
{
   private void Update() {
       if (Input.GetKeyDown(KeyCode.A))
       {
           DamagePopup.Create(transform.position,8,true);
            Debug.Log("temas");
       }
   }
}
