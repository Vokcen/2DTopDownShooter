using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;


public  class Timer:MonoBehaviour

{  public GameObject dialog;
public TMP_Text Level1textMesh;
 int goal=1;
 int currentPoint;
   public UnityEvent ara_sahne1, ara_sahne2,ara_sahne3;

   public int AraSahne;

    public int CurrentPoint { get => currentPoint; set => currentPoint = value; }

    private void Start()
  {
ara_sahne1.AddListener(AraSahne1);
ara_sahne2.AddListener(AraSahne2);
ara_sahne3.AddListener(AraSahne3);
 }
 private void Update() {
     if (AraSahne==1&&this.gameObject!=null)
     {
         ara_sahne1.Invoke();
     }
     if (AraSahne==2)
     {  
         ara_sahne2.Invoke();
     }
     if (AraSahne==3)
     {
         ara_sahne3.Invoke();
     } 
      if (Level1textMesh!=null)
      {
          Level1textMesh.text=CurrentPoint.ToString()+"/"+goal.ToString();

      }
    
     if (goal<=CurrentPoint)
     {
         Debug.Log("Görev tamam");
     }
 }
   void AraSahne1()
   {
    Debug.Log("1");
     StartCoroutine(scene2());
  AraSahne=0;
 
   }
   void AraSahne2()
   {             
       Debug.Log("2.sahenye geçiş");   
       AraSahne=0;
   }
   void AraSahne3()
{   goal=5;
     Debug.Log("3.sahneye geçiş"); 
    
        

    AraSahne=0;
}


IEnumerator scene2()
{ 
yield return new WaitForSeconds(5);
dialog.SetActive(true);  
yield return new WaitForSeconds(5);
    AraSahne=2;

}

  
}
