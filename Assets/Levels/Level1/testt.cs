using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class testt : MonoBehaviour
{
    public TMP_Text texmesh;
    public int goal;
    public int current;
       void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    texmesh.text=goal.ToString()+"/"+current.ToString();
    }
}
