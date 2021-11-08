using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetT : MonoBehaviour
{
    public string setter;
    public void click(){
        LoadingScreen.Nivel = setter;
    }
}
