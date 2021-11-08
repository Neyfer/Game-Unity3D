using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RebootGame : MonoBehaviour {

	
	public LevelController reintentar;
	public string Nivel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Restart()
	{
		SceneManager.LoadScene(Nivel);
		
		
		
}
}
