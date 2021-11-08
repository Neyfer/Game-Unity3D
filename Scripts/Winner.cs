using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Winner : MonoBehaviour
{
    public AudioSource Aceleracion;
    public AudioSource DesAceleacion;
    LevelController controlJuego;
    public GAMEOVER2R perdio;
     public AudioSource Ganador;
     public Camera ALGanar;
     public GameObject GANAR;
     public AudioSource Fondo;
     public AudioSource relenti;
     public GameObject Carga;
     public GameObject Carro;
    public AudioSource solo, Faded, DarkSide, unidad;

    private void Awake()
    {
        ALGanar.enabled = false;
       GANAR.SetActive(false);
        controlJuego = GameObject.Find("LevelController").GetComponent(typeof(LevelController)) as LevelController;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player"){
            solo.Stop();
            Faded.Stop();
            DarkSide.Stop();
            unidad.Stop();
            Aceleracion.Stop();
            DesAceleacion.Stop();
            ALGanar.enabled = true;
            controlJuego.desbloquearNivel(); 
            GANAR.SetActive(true);
            Ganador.Play();
            relenti.Stop();
            Fondo.Stop();
            Carro.SetActive(false);
            Carga.SetActive(false);
        }
    }

    public void reset(){
        
    }
    
}
