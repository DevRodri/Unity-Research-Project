﻿using UnityEngine;
using System.Collections;

public class WavesGen : MonoBehaviour {

	public GameObject waves;

	void OnTriggerEnter(Collider other) {

		if(other.tag =="Player")Application.LoadLevel(0);

		waves.particleSystem.randomSeed = 30;

		Vector3 vec = other.transform.position;
		Instantiate (waves, vec, Quaternion.identity);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

}
