﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-1,GetComponent<Rigidbody2D>().velocity.y);
	}
}
