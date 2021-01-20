using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer_orb : MonoBehaviour
{

    public float timer = 5f;
    public float speed;

    public GameObject effect;

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // при взаэмодії з гравцев змінюємо timeScale
        {
            Instantiate(effect, transform.position, Quaternion.identity);

            Time.timeScale = 0.5f;
            Invoke("ReturnTime", timer);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
        }
    }
    private void ReturnTime() // повертаємо timeScale до норми
    {
        Destroy(gameObject);
        Time.timeScale = 1f;
    }
}
