using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadedPlay : MonoBehaviour
{
    public Alone vars1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        vars1.solo.Stop();
        vars1.Faded.Play();
        vars1.DarkSide.Stop();
        vars1.unidad.Stop();
        vars1.Fondo.Stop();
    }
}
