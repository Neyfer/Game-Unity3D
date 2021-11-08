using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class obstaclescript : MonoBehaviour {
	
	public Transform Target;
	public Vector3 offset;
	public Vector3 neyfer;

	// Use this for initialization
	void Start () {
		
		 

	}



	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = Target.position + offset;
		transform.rotation = Target.rotation;

	}
}

	
	
