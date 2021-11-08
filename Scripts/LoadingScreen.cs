using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    public GameObject PantallaDeCarga;
    public AudioSource click;
    public Slider slider;
    public static string Nivel;
    // Start is called before the first frame update


//Activar el canvas
    private void Awake()
    {
        PantallaDeCarga.SetActive(false);
    }
    void Start()
    {
        Debug.Log(Nivel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Cambiar de escena al nivel pulsado
    public void CargarNivel(string NivelPulsado){
	click.Play();
        StartCoroutine(CargarAsync(NivelPulsado));
    }


    //Determinar El progreso del cambio de escena
    IEnumerator CargarAsync(string NivelPulsado){
        PantallaDeCarga.SetActive(true);
        AsyncOperation operation = SceneManager.LoadSceneAsync(Nivel);  

        
        while (!operation.isDone)
        {
            
        float progreso = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progreso;
            yield return null;
        }
    }
}
