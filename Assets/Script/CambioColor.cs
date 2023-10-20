using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    Color inicial;
    SpriteRenderer RigidbodySprite;
    float red;

    private bool choque;
    private float tiempoColoreado = 2.0f;

    void Start()
    {
        if(choque == false)
        { 
        RigidbodySprite = GetComponent<SpriteRenderer>();
        inicial = RigidbodySprite.color;
        }
    }

    private void OnCollisionEnter2D(Collision2D objeto)
    {
        StartCoroutine(MantenerColor());
    }

    IEnumerator MantenerColor()
    {
        choque = true;
        if (choque == true)
        {
            RigidbodySprite.color = Color.red;
        }
        yield return new WaitForSeconds(tiempoColoreado);
        choque = false;
        RigidbodySprite.color = inicial;
    }
}

