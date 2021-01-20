using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPatterns;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minTime = 0.35f;
    public int rand;

    private void Update()
    {
        if (timeBetweenSpawn <= 0 ){ //якщо інтервал <= 0 спавнимо випадкових опонентів на випадковій позиції
            if(startTimeBetweenSpawn <= 0.6f)
            {
                rand = Random.Range(0, enemyPatterns.Length/2);
            }
            else
            {
                rand = Random.Range(0, enemyPatterns.Length);
            }
            Instantiate(enemyPatterns[rand], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            if (startTimeBetweenSpawn > minTime)
            { 
                startTimeBetweenSpawn -= decreaseTime; // поступово зменшуємо інтервал між хвилями 
            }
            
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
