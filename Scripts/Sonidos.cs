using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
 
    public AudioSource Acelerar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }



    public void sonar(){
       Acelerar.Play();
       Debug.Log("Presiono");
    }

    public void OnPointerDown()
    {
        
    }

    public void noSonar(){
       Acelerar.Stop();
    }
}
