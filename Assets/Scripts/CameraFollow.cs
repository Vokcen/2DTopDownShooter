using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraFollow : MonoBehaviour
{
       public GameObject mainCharacter;

          void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position=mainCharacter.transform.position;
    }
}
