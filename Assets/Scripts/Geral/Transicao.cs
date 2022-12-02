using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Transicao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChamaCena(string nome) { // Transições de Scenas
		SceneManager.LoadScene(nome);
	}

	public void SairJogo() {
		Application.Quit();//Exit o Game 
	}
}
