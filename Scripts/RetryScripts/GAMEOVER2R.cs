using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEOVER2R : MonoBehaviour
{
    public AudioSource Acelerar;
    public AudioSource DesAcelerar;
    public GameObject PERDIO;
    public GameObject imagen;
    public GameObject texto;
    public GameObject Retry;
    public GameObject Menu;
    public AudioSource PerdioMusica;
    public AudioSource EnJuegoMusica;
    public AudioSource relenti;
   
    public GameObject Carga;
    private void Awake()
    {
       PERDIO.SetActive(false);
    }

    public void MostrarGameOver(){
        DesAcelerar.Stop();
        Acelerar.Stop();
       /* imagen.SetActive(true);
        Retry.SetActive(true);
        Menu.SetActive(true);
        texto.SetActive(true);*/
        PERDIO.SetActive(true);
        PerdioMusica.Play();
        EnJuegoMusica.Stop();
        relenti.Stop(); 
            Carga.SetActive(false);
    }
}
