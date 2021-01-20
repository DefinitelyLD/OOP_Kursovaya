using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); //рухаємось в напрямку гравця
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //якщо зыштовхуэмося с гравцем віднімаємо його життя в розмірі урону
        {
            Instantiate(effect, transform.position, Quaternion.identity);

            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }
    }
}
