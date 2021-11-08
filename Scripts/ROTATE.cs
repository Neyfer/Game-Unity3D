using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE : MonoBehaviour
{
    public Transform Stteering;
    public Transform Refrence;
    public Vector3 Offset;
    Vector3 GetRotation;
            

    
    

    // Start is called before the first frame update
    void Start()
    {
        
        GetRotation = transform.localEulerAngles;

    }

    // Update is called once per frame
    void Update()
    {
         GetRotation.z = Refrence.localEulerAngles.z;   
         transform.localEulerAngles = -GetRotation;
         
    }
}
