using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Checker : MonoBehaviour
{
    public static int carValue;
    public int setter;
    public static int envioroment;
    public int env_setter;
    public Toggle me;

    // Start is called before the first frame update

    public void Start(){
    }

    public void FixedUpdate(){
        
    }

public void toggles(){
    if(me == true){
        envioroment = env_setter;
        Debug.Log(envioroment);
    }
}

    public void change(){
        carValue = setter;
        Debug.Log(carValue);
    }

    public void validation(){
        if(envioroment == 1){
            LoadingScreen.Nivel = "Asphalt_Rain";
        }else if(envioroment == 2){
            LoadingScreen.Nivel = "Asphalt_Summer";
        }else if(envioroment == 3){
            LoadingScreen.Nivel = "Asphalt_Night";
        }
    
    
    Debug.Log(envioroment);
    Debug.Log(LoadingScreen.Nivel);
    }


}
