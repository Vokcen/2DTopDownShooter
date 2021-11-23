using UnityEngine;

public class CameraRotation : MonoBehaviour
{  
   public   float smooth = 5.0f;
    float tiltAngle = 60.0f;
    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position+=transform.forward*Speed*Time.deltaTime;            
        }
       
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        float y =Input.GetAxis("Horizontal")*Time.deltaTime*Speed;
        float x=-Input.GetAxis("Vertical") *Time.deltaTime*Speed;
        Vector3 newTarget= new Vector3(x,y,0);

        // Rotate the cube by converting the angles into a quaternion.
       
        // Dampen towards the target rotation
        transform.eulerAngles += newTarget;
    }
}
