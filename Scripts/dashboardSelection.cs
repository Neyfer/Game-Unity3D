using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dashboardSelection : MonoBehaviour
{
    public Image car;
    public Image car1;
    public Image car2;
   
    public void jeep(){
        car.color = Color.gray; 
        car1.color = Color.white;
        car2.color = Color.white;
    }
}
