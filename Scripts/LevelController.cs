using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    static public int nivelesDesbloqueados;
    public int nivelActual;
    public Button[] botones;
    CargarYGuardar cargarYGuardar;
    
//    Start is called before the first frame update

    private void Awake()
    {
        cargarYGuardar = GetComponent<CargarYGuardar>();
    }

    //Reducir calidad Grafica y cargar el progreso previo
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = -1;
        
       if(SceneManager.GetActiveScene().name=="Menu"){
       cargarYGuardar.Save();
           ActualizarBotones();
       } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Aumentar nivelesDesbloqueados cuando el jugador colisiona con el objetivo
    public void desbloquearNivel(){
        
        if(nivelesDesbloqueados < nivelActual){

            
            nivelesDesbloqueados = nivelActual;
            nivelActual++;
           
            }
        
        
    }

    //Generar y habilitar los botones cuando el jugador sube de nivel

    public void ActualizarBotones(){
        for (int i = 0; i < nivelesDesbloqueados; i++)
        {
            botones[i].interactable = true;
        }   
    }

}
