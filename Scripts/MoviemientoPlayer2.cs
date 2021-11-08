using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoviemientoPlayer2 : MonoBehaviour
{
    public LevelController Consola;
    public Text Drive;
    public Text Reverse;
    public Slider slider;
    public float speed;
    public WheelCollider Llanta1, Llanta2, Llanta3, Llanta4;
    public Rigidbody rigidbody;
    public Vector3 com;
    public float vel;
    // Start is called before the first frame updat


private void Awake()
{
    vel = speed;
}
    void Start()
    {
        Update();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.centerOfMass = com;
    }

    // Update is called once per frame
    void Update()
    {
        Llanta1.motorTorque = speed * SimpleInput.GetAxis("Vertical");
        Llanta2.motorTorque = speed * SimpleInput.GetAxis("Vertical");
        Llanta3.motorTorque = speed * SimpleInput.GetAxis("Vertical");
        Llanta4.motorTorque = speed * SimpleInput.GetAxis("Vertical");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * com, 1f);
    }



    public void FixedUpdate(){
        
        if(slider.value == 0){
            speed = vel;
            Reverse.color = Color.white;
            Drive.color = Color.blue;
        }else if(slider.value == 1){
            speed = -400;
            Reverse.color = Color.blue;
            Drive.color = Color.white;
        }
    }
}
