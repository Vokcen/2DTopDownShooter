using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLevel2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LevelSelector._levelSelector=LevelSelect.level2;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
           LevelSelector._levelSelector=LevelSelect.level1;
        }
          if (Input.GetKeyDown(KeyCode.S))
        {
          LevelSelector._levelSelector=LevelSelect.level2;
        }
          if (Input.GetKeyDown(KeyCode.D))
        {
            LevelSelector._levelSelector=LevelSelect.level3;
        }
    }
}
