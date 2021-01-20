using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] Enemy;

    void Start()
    {
        int rand = Random.Range(0, Enemy.Length); //обираэмо випадкового опонента
        Instantiate(Enemy[rand], transform.position, Quaternion.identity);    
    }

 
}
