﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class Score19 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.collider.tag == "Dart") {

			Scoring.score_count += 19;
			Debug.Log ("Hit 19");
			Debug.Log (Scoring.score_count);

			Rigidbody rb = collision.rigidbody;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			rb.useGravity = false;
			rb.isKinematic = true;
		}

	}
}
