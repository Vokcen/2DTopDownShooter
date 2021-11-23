using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum LevelSelect
{ 
    level1,
    level2,
    level3
    
    
}
public class LevelSelector :MonoBehaviour
{  
 
   public static LevelSelect _levelSelector;
   
      
  
   
    private void Update() {
        if (_levelSelector==LevelSelect.level1)
        {
            Debug.Log("1.level---- ");
        }
         if (_levelSelector==LevelSelect.level2)
        {
            Debug.Log("2..level---- ");
        }
          if (_levelSelector==LevelSelect.level3)
        {
            Debug.Log("3.level---- ");
        }
       
   }
}
