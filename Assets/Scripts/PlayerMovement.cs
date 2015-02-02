using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public int speed;
	public float rotateSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float vertical = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float horizontal = Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime;

		transform.Translate (0f, 0f, vertical);
		transform.Rotate (0f, horizontal, 0f);

	}

}
