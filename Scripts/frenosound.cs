using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frenosound : MonoBehaviour
{
    public AudioSource acelerator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Frenar(){
        acelerator.Stop();
    }
}
