using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ondisabler : MonoBehaviour
{
[SerializeField]Timer _t;
 private void OnDisable() {
     _t.AraSahne=3;
 }
}
