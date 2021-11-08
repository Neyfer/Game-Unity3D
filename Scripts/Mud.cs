using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud : MonoBehaviour
{
  public WheelCollider Llanta1,Llanta2,Llanta3,Llanta4;
  public GameObject Carro;
  public bool collision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


private void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.name=="Player"){
           collision = true;
          /* WheelFrictionCurve friction =  Llantas.forwardFriction;
           friction.stiffness = 0.18f;
           Llantas.forwardFriction = friction;*/

            WheelFrictionCurve friction1 = Llanta1.forwardFriction;
            WheelFrictionCurve friction2 = Llanta2.forwardFriction;
            WheelFrictionCurve friction3 = Llanta3.forwardFriction;
            WheelFrictionCurve friction4 = Llanta4.forwardFriction;
            friction1.stiffness = 0.02f;
            friction2.stiffness = 0.02f;
            friction3.stiffness = 0.02f;
            friction4.stiffness = 0.02f;
            Llanta1.forwardFriction = friction1;
            Llanta2.forwardFriction = friction2;
            Llanta3.forwardFriction = friction3;
            Llanta4.forwardFriction = friction4;
       }

       
   }

   private void OnTriggerExit(Collider other)
   {
       if(other.gameObject.name=="Player"){
           collision = true;
          /* WheelFrictionCurve friction =  Llantas.forwardFriction;
           friction.stiffness = 0.18f;
           Llantas.forwardFriction = friction;*/

            WheelFrictionCurve friction1 = Llanta1.forwardFriction;
            WheelFrictionCurve friction2 = Llanta2.forwardFriction;
            WheelFrictionCurve friction3 = Llanta3.forwardFriction;
            WheelFrictionCurve friction4 = Llanta4.forwardFriction;
            friction2.stiffness = 1;
            friction1.stiffness = 1;
            friction3.stiffness = 1;
            friction4.stiffness = 1;
            Llanta1.forwardFriction = friction1;
            Llanta2.forwardFriction = friction2;
            Llanta3.forwardFriction = friction3;
            Llanta4.forwardFriction = friction4;
       }

       
   }
}
