using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VOLANTE : MonoBehaviour {
	public WheelCollider HTire1;
	public WheelCollider HTire2;
	public int rotacion;
	public GameObject Carro;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		HTire1.steerAngle = rotacion * SimpleInput.GetAxis ("Horizontal");
		HTire2.steerAngle = rotacion * SimpleInput.GetAxis ("Horizontal");
	}
}
