using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
	public int numeroUno = 30;
	public int numeroDos = 60;
	public int numeroTres;
	public float numeroCuatro;
	public float numeroCinco = 15.5f;


	// Use this for initialization
	void Start () {
		Debug.Log("La suma de " + numeroUno + " mas " + numeroTres + " mas " + numeroCuatro + " es igual a = " + (numeroUno + numeroTres + numeroCuatro));
		Debug.Log("La resta de " + numeroUno + " menos " + numeroDos + " menos " + numeroCinco + " es igual a = " + (numeroUno - numeroDos - numeroCinco));
		Debug.Log("La operacion de " + numeroUno + " mas " + numeroDos + " por " + numeroCinco + " es igual a = " + ((numeroUno + numeroDos) * numeroCinco));
		Debug.Log("La operacion de " + numeroUno + " menos " + numeroTres + " dividido entre " + numeroCinco + " mas " + numeroCuatro + " es igual a = " + ((numeroUno - numeroTres) / (numeroCinco + numeroCuatro)));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
