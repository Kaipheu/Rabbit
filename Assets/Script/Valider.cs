using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Valider : MonoBehaviour {
	bool Clique = false;
	// Use this for 
	void Update(){
		if (Clique){
			var screenPoint = Vector3(Input.mousePosition);
			screenPoint.z = 10.0f; //distance of the plane from the camera
			transform.position = Camera.main.ScreenToWorldPoint(screenPoint);

			RectTransform  Rect = gameObject.GetComponent<RectTransform>();

			Rect.anchoredPosition = Input.mousePosition -new Vector3 (-60,0,0);
			Debug.Log ("Clique deplace"+Rect.anchoredPosition);
		}
	
	}
	// Update is called once per frame
	public void Clicpibk () {
		Clique = !Clique;
		Debug.Log ("Clique");
	}	
}
