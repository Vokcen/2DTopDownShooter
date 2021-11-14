using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
  public static ObjectPool current;
    public GameObject pooledObject;
    public int pooledAmount;
    public bool autoSize;

    private List<GameObject> pooledObjects;
    private void Awake()
    {
        current = this;
    }
    void Start()
    {

        pooledObjects = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);

        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        if (autoSize)
        {
            GameObject obj = Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }
            
        return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
