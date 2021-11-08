using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toogleChecks : MonoBehaviour
{
    public Toggle env0;
    public Toggle env1;
    public Toggle env2;


    public void check(){
        env0.isOn = true;
         env1.isOn = false;
            env2.isOn = false;
    }
}
