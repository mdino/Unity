using UnityEngine;
using System.Collections;

public class movment2d : MonoBehaviour {

	public float movementSpeed = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("left") || Input.GetKey ("a")) {
			transform.position -= Vector3.right * movementSpeed * Time.deltaTime;
				}
		else if (Input.GetKey ("right") || Input.GetKey ("d")) {
			transform.position -= Vector3.left * movementSpeed * Time.deltaTime;
		}
	}
}
