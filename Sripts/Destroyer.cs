using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float lifetime;
    void Start() //знищуємо об'екти через деякий проміжок часу
    {
        Destroy(gameObject, lifetime);
    }

 
}
