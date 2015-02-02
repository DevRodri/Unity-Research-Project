using UnityEngine;
using System.Collections;

public class PorteriaChangecolor : MonoBehaviour {

	// Use this for initialization
	private float color;
	private bool changed;

	void Start () {

		changed = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.tag != "Player"){
			if (!changed) {

							transform.renderer.material.color = new Color (1, 0, 0);
							changed = true;
			} else {
			
				transform.renderer.material.color = new Color (0, 0, 1);
				changed = false;
			}
		}
	}
	
}
