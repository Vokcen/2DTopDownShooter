using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] float magnitude;
  
    private float _forceValue = 12f;
    
    public CameraShake cam;


   
    private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Enemy")
    {
            StartCoroutine(cam.Shake(duration, magnitude));

        }
}
}
