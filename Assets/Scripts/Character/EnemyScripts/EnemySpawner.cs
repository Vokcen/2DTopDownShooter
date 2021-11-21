using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  EnemySpawner  : MonoBehaviour
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
        GameObject obj = ObjectPool.current.GetPooledObject();
        if (obj == null) return;
        obj.SetActive(true);
        obj.transform.position = SpawnPoints[randPos].position;
        

        
        //GameObject  newEnemy=Instantiate(enemySpawner,SpawnPoints[randPos].position,Quaternion.identity);
    }
}
