using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    PlayerMovement playerMovement;
    GameObject player;
    public float effectTime;

    void Awake ()
    {
        //Mencari game object dengan tag "Player"
        player = GameObject.FindGameObjectWithTag ("Player"); 

        playerMovement = player.GetComponent<PlayerMovement>();
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
        playerMovement.isFast = true;
        playerMovement.effectItem = effectTime;
    }
}
