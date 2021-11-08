using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public GameObject levels;
    public GameObject Menu;
    
    public void click(){
        levels.SetActive(false);
        Menu.SetActive(true);
    }

}
