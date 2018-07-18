using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Entrer : MonoBehaviour {
	public GameObject Enigme;
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Entrer !");
		int Rnd;
		float RndT = Random.value*10;
		Rnd = (int) RndT;
		Debug.Log (Rnd);
		if(Rnd % 2 == 1){
		Instantiate (Enigme);
		}
	}
}
