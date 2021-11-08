using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float minutos;
    private int CantidadADisminuir = 1;
    public float seccons;
    public int seccons2;
    public Text Tiempo;
    public GAMEOVER2R perde;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame

    public void FixedUpdate()
    {
        
     seccons2 = Mathf.RoundToInt(seccons);
    }
    void Update()
    {

        if(minutos <0){
            perde.MostrarGameOver();
        }

        

       


        if(minutos < 1f && seccons ==0 )
         {
              CantidadADisminuir = 0;
         }else{
             seccons -= CantidadADisminuir * Time.deltaTime;
         }
         if(seccons < 1f)
         {
             minutos -= 1f;
             seccons = 60f;
         }
         

        Tiempo.text = minutos.ToString() + ":" + seccons2.ToString();   
    }
}




