using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACTUALSCENE : MonoBehaviour
{  public LevelController controlador;
    
    public int cualEscena;
    // Start is called before the first frame update
    void Start()
    {
        cualEscena = controlador.nivelActual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
