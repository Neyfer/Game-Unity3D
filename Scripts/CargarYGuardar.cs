using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class CargarYGuardar : MonoBehaviour
{

    private string rutaArchivo;
    static bool FirstTime=true;

    private void Awake()
    {
        rutaArchivo=Application.persistentDataPath + "/datos.dat";
        if(FirstTime){
            Load();
            FirstTime=false;
        }
    }

    // Start is called before the first frame update
public void Save(){
    BinaryFormatter bf = new BinaryFormatter();
    FileStream file=File.Create(rutaArchivo);
    DatesToSave datos = new DatesToSave(LevelController.nivelesDesbloqueados);
    bf.Serialize(file, datos);
    file.Close();
}

public void Load(){
    if(File.Exists(rutaArchivo)){
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(rutaArchivo, FileMode.Open);
        DatesToSave datos =(DatesToSave) bf.Deserialize(file);
        LevelController.nivelesDesbloqueados = datos.nivelesDesbloqueados; 
    }else{
        LevelController.nivelesDesbloqueados=2;
    }
}
}


[System.Serializable]
class DatesToSave{
    public int nivelesDesbloqueados;

    public DatesToSave(int nivelesDesbloqueados_)
    {
        nivelesDesbloqueados = nivelesDesbloqueados_;
    }
}


