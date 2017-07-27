using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChararcterMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log("x = "+GetComponent<Rigidbody2D>().velocity.x);
		Debug.Log("y = "+GetComponent<Rigidbody2D>().velocity.y);

		if (Input.GetKey(KeyCode.Space)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, 3);
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (1,GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}
