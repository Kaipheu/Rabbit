using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Enigme_gen : MonoBehaviour {
    
	private int i = 0;
	private int j = 0;

	private float pos_x = -200f;
	private float deltapos_x = 60f;
	public string Enigme = "X - XI = I";
    
	private GameObject[] charsTXT = new GameObject[100];

    void Start(){

        for (i = 0; i < Enigme.Length; i++){ //on parcourt la chaîne
            switch(Enigme[i]){
                case 'I':
					AddText("I", 0);
                    pos_x += 0.5f * deltapos_x;
                    break;
                case 'X':
					AddText("/", 0);
					AddText("\\", 0);
                    pos_x += 0.5f * deltapos_x;
                    break;
				case '-':
					AddText("-", 0);
					pos_x += 0.5f * deltapos_x;
                    break;
                case '=':
					AddText("-", 15);
					AddText("-", -15);
                    pos_x += 0.5f * deltapos_x;
                    break;
				case ' ':
					pos_x += 0.5f * deltapos_x;
					break;

            }
        }          
    } 
	void AddText(string chr, float y){
		Text txt;
		Debug.Log(j);
		charsTXT[j] = Instantiate(Resources.Load("Enigme_txt"), new Vector3(pos_x, y, 0), Quaternion.identity) as GameObject;
		charsTXT[j].transform.SetParent(this.transform, false);
		txt = charsTXT[j].GetComponent(typeof(Text)) as Text;
		txt.text = chr;
		j++;
	}
}
