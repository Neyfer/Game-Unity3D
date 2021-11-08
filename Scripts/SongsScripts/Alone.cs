using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alone : MonoBehaviour
{
    public AudioSource Faded;
    public AudioSource solo;
    public AudioSource DarkSide;
    public AudioSource unidad;
    public AudioSource Fondo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        solo.Play();
        Faded.Stop();
        DarkSide.Stop();
        unidad.Stop();
        Fondo.Stop();
    }
}
