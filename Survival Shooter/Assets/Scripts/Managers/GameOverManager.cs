﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;       
    public Text warningText;            


    Animator anim;                          
    float restartTimer; 

    bool isDead = false;                   


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0 && !isDead)
        {
            isDead = true;
            anim.SetTrigger("GameOver");
        }
    }

    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m",Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }
}