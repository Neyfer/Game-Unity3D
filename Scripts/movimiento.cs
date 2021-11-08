using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour {
	
    public Text Drive;
    public Text Reverse;
    public Slider slider;
	public float CurrentSpeed;
	public int velocidadMaxima = 80;
	public RPM revolutions;
	public WheelCollider Llanta1;
	public WheelCollider Llanta2;
	public WheelCollider Llanta3;
	public WheelCollider Llanta4;
	public int speed;
	public int inclinacion;
	public Rigidbody rb;
	public string name;
	private bool presiono = false;
	public AudioSource Crash;
	public GAMEOVER2R perder;
	public GameObject Ganar;
	public GameObject Perder;
	public Vector3 com;
	public int reverse_speed =-400;

	public int vel;
	
	
	private void Awake()
	{
		vel = speed;
		Ganar.SetActive(false);
		Perder.SetActive(false);
	}

	// Use this for initialization
	void Start () {
		Update ();
		rb = GetComponent <Rigidbody> ();
		{
			rb.centerOfMass = com;
		}

		

	}
	// Update is called oce per frame
	public void Update () {
		
		CurrentSpeed = rb.velocity.magnitude * 3.6f;

		//Llanta1.steerAngle = -inclinacion * Input.GetAxis ("Horizontal");
		//Llanta2.steerAngle = -inclinacion * Input.GetAxis ("Horizontal");
		if(CurrentSpeed < 60){
		Llanta4.motorTorque = -speed *SimpleInput.GetAxis("Vertical");
		Llanta3.motorTorque = -speed * SimpleInput.GetAxis("Vertical");
		Llanta1.motorTorque = -speed * SimpleInput.GetAxis("Vertical");
		Llanta2.motorTorque = -speed * SimpleInput.GetAxis("Vertical");
		}else if(CurrentSpeed>69){
		Llanta4.motorTorque = 0;
		Llanta3.motorTorque = 0;
		Llanta1.motorTorque = 0;
		Llanta2.motorTorque =0;
		}
	}

	public void FixedUpdate(){
	
        if(slider.value == 0){
            speed = vel;
            Reverse.color = Color.white;
            Drive.color = Color.blue;
        }else if(slider.value == 1){
            speed = reverse_speed;
            Reverse.color = Color.blue;
            Drive.color = Color.white;
        }

    
	}



	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.name == "obstacle") {
			Crash.Play();
			Llanta4.brakeTorque = 500000;
			Llanta3.brakeTorque = 500000;
			Llanta2.brakeTorque = 500000;
			Llanta1.brakeTorque = 500000;
			perder.MostrarGameOver();
		}

		

	
	}

	
}



