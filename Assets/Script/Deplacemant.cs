using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacemant : MonoBehaviour {
	public int Reduction;
	
	// Update is called once per frame
	void Update () {
		var x = Input.GetAxis ("Horizontal")/Reduction;
		var y = Input.GetAxis ("Vertical")/Reduction;
		transform.Translate(x, y,0);
	}
}
