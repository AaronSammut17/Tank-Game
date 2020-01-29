using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    
    public static int enemyCount = 0;
    Text enemy;
    string sceneName;

    void Start(){
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        enemy = GetComponent<Text>();
    }
    
    // Update is called once per frame
    void Update()
    {
        enemy.text = "Enemies: "+enemyCount;

        if(enemyCount == 18 && sceneName == "Lvl2"){
            SceneManager.LoadScene("Lvl3");
        }

        else if(enemyCount == 23 && sceneName == "Lvl3"){
            SceneManager.LoadScene("Win");
        }
    }
}