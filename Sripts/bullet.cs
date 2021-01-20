using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    
    void Start() //задаємо скорость кулі
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Enemy enemy))  //якщо колайдер це противник , ми знищоємо його та кулю
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
       
    }
   
}
