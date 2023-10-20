using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    private float movimientoEjeX;
    private float movimientoEjeY;
    public float velocidadMovimiento = 5.0f;

    private bool stun = false;
    private float tiempoStun = 2.0f;



    void Update()
    {

        if (stun == false)
        {
            movimientoEjeY = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
            movimientoEjeX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
            transform.Translate(movimientoEjeX, movimientoEjeY, 0);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {

     StartCoroutine(DesactivarStun());
    }

    IEnumerator DesactivarStun()
    {
        stun = true;
        yield return new WaitForSeconds(tiempoStun);
        stun = false;

    }
}