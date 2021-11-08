using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public int SongState = 1;
    public AudioSource Fondo, solo, Faded, DarkSide, unidad;
    public GameObject NoSong;
    // Start is called before the first frame update
    void Start()
    {
        NoSong.SetActive(false);
    }

    public void StopSong(){
        if(SongState == 1){
            Fondo.Stop();
            solo.Stop();
            Faded.Stop();
            DarkSide.Stop();
            unidad.Stop();
            SongState = 0;
            NoSong.SetActive(true);
        }else if(SongState == 0){
            Fondo.Play();
            NoSong.SetActive(false);
            SongState=1;
        }
    }
}
