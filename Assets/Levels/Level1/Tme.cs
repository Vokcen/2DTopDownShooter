using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tme : MonoBehaviour
{  [SerializeField]Timer time;

     private void OnDisable() {
         time.AraSahne=1;
    
     }
}
