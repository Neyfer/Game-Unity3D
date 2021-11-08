using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_speed_toyota_only : MonoBehaviour
{
    public movimiento car_script;
 
 private void Awake()
 {
     car_script.reverse_speed = 400;
 }
}
