using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlueSpawner : MonoBehaviour
{
   
    
    public Transform[] SpawnPoints;
    public float spawnTime;

    void Start()
    {
        InvokeRepeating("Spawner",0.5f,spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawner()
    {
        int randPos=Random.Range(0,SpawnPoints.Length);
        GameObject obj = EnemyBluePool.current.GetPooledObject();
        if (obj == null) return;
        obj.SetActive(true);
        obj.transform.position = SpawnPoints[randPos].position;
        

        
        //GameObject  newEnemy=Instantiate(enemySpawner,SpawnPoints[randPos].position,Quaternion.identity);
    }
}
