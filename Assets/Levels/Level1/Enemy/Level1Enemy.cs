using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Enemy : MonoBehaviour
{  public GameObject dialog;
     float distance;
      [SerializeField]float enemySpeed;
      int hp=100;
      int damageAmaount;
      Transform playerPos;
      [SerializeField]Timer tim;
     
    void Start()
    {
         playerPos=GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        AIFollowCharacter();
    }
      void AIFollowCharacter()
    {
        distance = Vector2.Distance(transform.position, playerPos.position);
        transform.position =Vector2.MoveTowards(transform.position,playerPos.position,enemySpeed*Time.deltaTime);
    } 
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag=="Player")
        { dialog.SetActive(true);
            this.gameObject.SetActive(false);
           
        }
    }
       
    
}
