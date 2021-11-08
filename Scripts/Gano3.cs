using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gano3 : MonoBehaviour
{
    public GameObject Boton;
    public Text Ganador;
   
    public string sceneName;
    // Start is called before the first frame update

    private void Awake()
    {
        Boton.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Player"){
            SceneManager.LoadScene(sceneName);
        }
    }
}
