using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valider : MonoBehaviour {
	bool Clique = false;
	Vector3 PosInit;
	void Update(){
		if (Clique){
			RectTransform  Rect = gameObject.GetComponent<RectTransform>();
			Rect.anchoredPosition = Input.mousePosition - PosInit;
			Debug.Log ("Clique deplace"+Rect.anchoredPosition);
		}
	
	}
	// Update is called once per frame
	public void Clicpibk () {
		Clique = !Clique;
		Debug.Log ("Clique");
		RectTransform  Rect = gameObject.GetComponent<RectTransform>();
		Vector3 Tmp = Rect.anchoredPosition;
		PosInit = Input.mousePosition - Tmp;
	}	
}
