using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Entrer : MonoBehaviour {
	public GameObject Enigme;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Entrer !");
		Instantiate (Enigme);
	}
}
