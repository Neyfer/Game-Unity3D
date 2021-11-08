using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public string NivelActual;
    public string NextLevel;
    public string menu;
    public LevelController reintentar;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void regresar()
    {

         SceneManager.LoadScene(NivelActual);
    }

    public void Next(){
             SceneManager.LoadScene(NextLevel);
        
    }

    public void Menu(){
        SceneManager.LoadScene(menu);
    }
}
