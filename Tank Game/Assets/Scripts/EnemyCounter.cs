using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour
{
    
    public static int enemyCount = 0;
    Text enemy;
    public static string totalEnemies = "00";
    
    void Start(){

        enemy = GetComponent<Text>();

    }
    
    // Update is called once per frame
    void Update()
    {
        enemy.text = "Enemies: "+enemyCount+" / "+totalEnemies;

    }
}