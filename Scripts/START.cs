using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour
{
    public GameObject Niveles;
    public GameObject Esto;


    private void Awake()
    {
        Niveles.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void iniciar(){
        Niveles.SetActive(true);
        Esto.SetActive(false);
    }
}
