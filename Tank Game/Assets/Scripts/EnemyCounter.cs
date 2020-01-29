using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public static int enemyCount = 0;
    Text enemy;

    void Start()
    {
        enemy = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.text = "Enemies: "+enemyCount+" / 22";
    }
}
