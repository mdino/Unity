using UnityEngine;
using System.Collections;

public class scoretitle : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	

	void Update() {

		guiText.text = " " + Score.score;

		/*if (Input.touchCount == 1) {
			guiText.enabled=false;

		}


		else if (Input.GetKey ("right") || Input.GetKey ("d")) {
			guiText.enabled=false;
		
	} 
*/


		} 
