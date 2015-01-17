using UnityEngine;
using System.Collections;

public class Flotacion : MonoBehaviour {


	bool colision = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(colision){
			this.rigidbody.AddExplosionForce(20.0f - this.rigidbody.velocity.y,this.transform.position,3.0f);
		}
	}

	void Update () {
		Debug.Log (this.rigidbody.velocity.y);
	}

	void OnTriggerEnter(Collider other){
		if (!colision){
			colision = true;
		} else {
			colision = false;
		}
	}
}
