using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{ 

	public float velocidad;
	public float maxTransform;
	public float minTransform;

	void Start()
	{
		//los parámetros con los que inicia
		velocidad = 5f;
		maxTransform = 9;
		minTransform = -8;
	}

	void Update()
	{

		transform.Translate(velocidad * Time.deltaTime, 0, 0);
		checkDirection();


	}

	public void checkDirection()
	{
		if (transform.position.x >= maxTransform)
		{
			velocidad = velocidad * -1;
		}
		else if (transform.position.x <= minTransform)
		{
			velocidad = velocidad * -1;
		}
	}




}