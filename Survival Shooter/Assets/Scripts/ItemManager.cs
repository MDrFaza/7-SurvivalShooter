using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] itemPrefab;
    public Transform[] spawnPoint;
    GameObject item;
    bool isSpawn;
    int index;

    void Start(){
        isSpawn = false;
        SpawnItem();
        InvokeRepeating("CheckSpawn", 30f, 30f);
        index = 0;
    }

    void CheckSpawn(){
        item = GameObject.FindGameObjectWithTag ("Item");
        if(item == null){
            isSpawn = false;
        }
    }

    void Update(){
        if(isSpawn){
            return;
        }
        SpawnItem();
    }

    public void SpawnItem(){
        if(index > 2){
            index = 0;
        }
        isSpawn = true;
        StartCoroutine(Delay());
    }

    IEnumerator Delay(){
        yield return new WaitForSeconds(10f);
        int spawn = Random.Range(0, 2);
        Instantiate(itemPrefab[spawn], spawnPoint[index].position, spawnPoint[index].rotation);
        index++;
    }
}
