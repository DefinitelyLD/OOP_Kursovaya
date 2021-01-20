using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost_orb : MonoBehaviour
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
            if (other.CompareTag("Player")) //змінюємо прозорість спрайту гравця та вимикаємо його BoxCollider2D
            {
                Instantiate(effect, transform.position, Quaternion.identity);

                other.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
                other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Invoke("ReturnVisibility", timer);
                gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
        }
        }
        private void ReturnVisibility() //повертаємо зміни назад
        {
            FindObjectOfType<Player>().gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            FindObjectOfType<Player>().gameObject.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(gameObject);
    }

    
}
