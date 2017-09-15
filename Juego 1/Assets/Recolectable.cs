using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectable : MonoBehaviour {

	public GameObject Dulce;
	private int NumMaximo = 9;


	void Start()
	{
		for (int contador = 0; contador <= NumMaximo; contador++) {
			Vector3 position = new Vector3 (Random.Range (-5.0f, 5.0f), Random.Range (4.0f, -5.0f), 0);
			Instantiate (Dulce, position, Quaternion.identity);
		}
	}
	}

