using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Load a level
	public void LoadLevel(string name){

		SceneManager.LoadScene(name);
	}

	// To quit the game
	public void Quit(){

		Application.Quit();
	}
}
