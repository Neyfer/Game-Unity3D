using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity : MonoBehaviour
{
    public Alone vars2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        vars2.solo.Stop();
        vars2.Faded.Stop();
        vars2.DarkSide.Stop();
        vars2.unidad.Play();
        vars2.Fondo.Stop();
    }
}
