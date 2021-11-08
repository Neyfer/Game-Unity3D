using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMusicAlbum : MonoBehaviour
{
    public  Image este;
    public GameObject Container;
    public int ContainerState = 0;
    // Start is called before the first frame update
    void Start()
    {
        Container.SetActive(false);
    }

    public void FixedUpdate(){
        if(ContainerState == 1){
            este.color = Color.blue;
        }else{
            este.color = Color.white;
        }
    }

    public void OpenContainer(){
        if(ContainerState == 0){
        Container.SetActive(true);
        ContainerState = 1;
        }else if(ContainerState == 1){
            Container.SetActive(false);
            ContainerState = 0;
        }
    }
}
