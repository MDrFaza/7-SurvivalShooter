using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    PlayerHealth playerHealth;
    GameObject player;
    public int itemEffect;

    void Awake ()
    {
        //Mencari game object dengan tag "Player"
        player = GameObject.FindGameObjectWithTag ("Player"); 

        playerHealth = player.GetComponent<PlayerHealth>();
    }

    void OnTriggerEnter (Collider other)
    {
        //Set player in range
        if(other.gameObject == player && other is CapsuleCollider)
        {
            UseItem();
            Destroy (gameObject);
        }
    }

    void UseItem(){
        playerHealth.HealthUp(itemEffect);
    }
}
