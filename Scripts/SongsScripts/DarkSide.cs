using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSide : MonoBehaviour
{
    public Alone vars;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        vars.solo.Stop();
        vars.Faded.Stop();
        vars.DarkSide.Play();
        vars.unidad.Stop();
        vars.Fondo.Stop();
    }
}
