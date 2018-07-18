using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valider : MonoBehaviour {
	bool Clique = false;// Si vrai il y a déplacement
	Vector3 PosInit; // position initiale de l'objet
	RectTransform  Rect;


	 void Start(){
		Rect = gameObject.GetComponent<RectTransform> ();

	}

	void Update(){
		if (Clique){
			Rect.anchoredPosition = Input.mousePosition - PosInit; // Changement des position de l'objet.
			Debug.Log ("Clique deplace"+Rect.anchoredPosition);
		}
	
	}
	public void Clicpibk () { // Fontion appeler lorsque l'on appuie sur l'objet
		Clique = !Clique;
		Debug.Log ("Clique");
		Vector3 Tmp = Rect.anchoredPosition;
		PosInit = Input.mousePosition - Tmp;
	}	
	public void Valdation(){// Fonction apeller quant ont appui sur le bouton Valider
		// 

	}
}
