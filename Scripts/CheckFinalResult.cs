using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckFinalResult : MonoBehaviour
{
    public GameObject jeep;
    public GameObject Nissan;
    public GameObject Toyota;
    public RPM rpm;
    public RPM rpm2;
    public Rigidbody jeepr;
    public Rigidbody nissanr;
    public Rigidbody toyotar;
    public AudioSource ralenti;
    public AudioClip ralenti_nissan;
    public AudioClip ralenti_jeep;
    public AudioClip ralenti_toyota;
    public movimiento carro_script;
    public GameObject jeep_canvas;
    public GameObject toyota_canvas;
    public GameObject nissan_canvas;

    
    // Start is called before the first frame update
    void Start()
    {
        if(Checker.carValue == 1){
            jeep.SetActive(true);
            rpm.Carro = jeepr;
            rpm2.Carro = jeepr;
            ralenti.clip = ralenti_jeep;
            jeep_canvas.SetActive(true);
        }else if(Checker.carValue == 2){
            Nissan.SetActive(true);
            nissan_canvas.SetActive(true);
            rpm.Carro = nissanr;
            rpm2.Carro = nissanr;
            ralenti.clip = ralenti_nissan;
        }else if(Checker.carValue == 3){
            Toyota.SetActive(true);
            toyota_canvas.SetActive(true);
            rpm.Carro = toyotar;
            rpm2.Carro = toyotar;
             ralenti.clip = ralenti_toyota;
        }


    }

    // Update is called once per frame
    void Update()
    {
    }

    public void nada(){
        
    }
}
   
