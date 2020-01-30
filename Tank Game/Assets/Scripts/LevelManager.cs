using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{	
	string sceneName;


	void Start(){
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

		if(sceneName == "Lvl1"){
            EnemyCounter.totalEnemies = "12";
        }
        if(sceneName == "Lvl2"){
            EnemyCounter.totalEnemies = "18";
        }
        if(sceneName == "Lvl3"){
            EnemyCounter.totalEnemies = "25";
        }

    }

	void Update()
    {

        if( EnemyCounter.enemyCount == 12 && sceneName == "Lvl1"){
            SceneManager.LoadScene("Lvl2");
            EnemyCounter.enemyCount = 0;
        }

        if( EnemyCounter.enemyCount == 18 && sceneName == "Lvl2"){
            SceneManager.LoadScene("Lvl3");
            EnemyCounter.enemyCount = 0;
        }

        else if( EnemyCounter.enemyCount == 25 && sceneName == "Lvl3"){
            SceneManager.LoadScene("Win");
            EnemyCounter.enemyCount = 0;
        }
    }

    // Load a level
	public void LoadLevel(string name){

		SceneManager.LoadScene(name);
	}

	// To quit the game
	public void Quit(){

		Application.Quit();
	}
}
