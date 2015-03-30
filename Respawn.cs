using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Player") {
			//Application.LoadLevel(Random.Range(1, 3));
			//Application.LoadLevel ( Application.loadedLevel);
			Application.LoadLevel ("score");
		}
	}
}
