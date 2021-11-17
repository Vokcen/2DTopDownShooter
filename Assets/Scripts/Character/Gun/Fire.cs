using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]Transform targetPoint;
    [SerializeField]GameObject bulletPrefab;
    [SerializeField]float  _forceValue;
   Rigidbody2D rg;
    [SerializeField] GameObject fireLight;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartCoroutine(FireB());
        }
    }

    void FireBullet()
    {
        GameObject bullet=Instantiate(bulletPrefab,targetPoint.position,targetPoint.rotation);
        rg=bullet.GetComponent<Rigidbody2D>();
        rg.AddForce(targetPoint.up*_forceValue,ForceMode2D.Impulse);
    }

   IEnumerator FireB()
    {
        FireBullet();
        fireLight.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        fireLight.SetActive(false);
    }
}
