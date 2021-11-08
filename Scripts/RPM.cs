using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPM : MonoBehaviour
{
    public AudioSource Gravel;
    public movimiento Mover;
    public float VelocidadMaxmima;
    public float MaxSpeed;
    public float MinArrowAngle;
    public float MaxArrowAngle;
    public Transform Marcadordekm;
    public Text speedometer;
    public float speed3; //The float value of the speed
    public int Speed2;
    public Rigidbody Carro;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    /*public void TomarLasRPM(){
        Vueltas = Seleccionarllantas.Llanta1.rpm;
        Speed = - (2 * 3.6 * 3.14 * 0.47 * Vueltas / 60);
        speed3 = (float)Speed;
        Speed2 = Mathf.RoundToInt(speed3);
    }*/

    public void Velocidad(){
        speed3 = Carro.velocity.magnitude * 3.6f;
        Speed2 = Mathf.RoundToInt(speed3);
        
        speedometer.text =  Speed2.ToString() + "Km/h";

        Marcadordekm.localEulerAngles = new Vector3(0,0, -Mathf.Lerp(MaxArrowAngle, MinArrowAngle, speed3/MaxSpeed));


        if(Marcadordekm.localEulerAngles.z > 11.9f){
            MaxSpeed = 200;
        }
    }

    

    // Update is called once per frame
    public void Update()
    {

       //TomarLasRPM();
       Velocidad();
    }


    public void FixedUpdate(){
        if(Speed2 > 1){
            if(!Gravel.isPlaying){
                Gravel.Play();
            }
        }

        if(Speed2 == 0){
            Gravel.Stop();
        }

         
    }


}
