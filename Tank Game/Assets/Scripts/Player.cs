using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public CharacterController2D controller;
    
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

       if (Input.GetButtonDown("Jump")){
           
           jump = true;

       } 

    }

    void FixedUpdate (){

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void OnCollisionEnter2D (Collision2D hitInfo){

        if (hitInfo.gameObject.tag.Equals ("Boundary")){
            string restartName = LevelManager.sceneName;
            SceneManager.LoadScene(restartName);
            EnemyCounter.enemyCount = 0;
        }

    }
}
