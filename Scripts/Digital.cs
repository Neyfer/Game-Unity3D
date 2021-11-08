using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Digital : MonoBehaviour
{
    public RPM SacarVelocidad;
    public TextMeshPro velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocidad.text = SacarVelocidad.Speed2.ToString();
    }
}
