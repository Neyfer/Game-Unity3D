using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirarPlayer2 : MonoBehaviour
{
    public MoviemientoPlayer2 correrScript;
    public float MaxSteering = 20;

    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        correrScript.Llanta1.steerAngle = MaxSteering * SimpleInput.GetAxis("Horizontal");
        correrScript.Llanta2.steerAngle = MaxSteering * SimpleInput.GetAxis("Horizontal");

    }
}
