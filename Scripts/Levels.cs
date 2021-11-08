using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{
    public string nivel1;
    public string nivel2;
    public string nivel3;
    public AudioSource click;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void abrirNiveUno(){
        click.Play();
        SceneManager.LoadScene(nivel1);
    }

    public void abrirNiveDos(){

            click.Play();
        SceneManager.LoadScene(nivel2);
    }

    public void AbrirNivel3(){
        click.Play();
        SceneManager.LoadScene(nivel3);
    }
}
