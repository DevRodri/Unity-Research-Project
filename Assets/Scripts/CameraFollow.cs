using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject target;

	public float height;
	public float distance;

	private Vector3 offset;

	public float damp;
	// Use this for initialization
	void Start () {
		//transform.position = target.transform.position;
		//transform.rotation = target.transform.rotation;
		//offset = 5*(target.transform.position - transform.position);
		offset = (target.transform.position +(target.transform.up * height) - transform.position); 
		//height += offset.y;

	}

	void Update () {
		offset.y = height;
	}
	
	// Update is called once per frame
	void LateUpdate () {

		float desiredAngle = target.transform.eulerAngles.y;
		Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
		//offset.y += height;

		Vector3 targetPos = target.transform.position - (rotation * offset);

		transform.position = Vector3.Slerp (transform.position, targetPos, damp * Time.deltaTime);

		//transform.position = target.transform.position - (rotation * offset);

		//Vector3 targetPos = target.transform.position + offset;

		//transform.position = Vector3.Lerp (transform.position, targetPos, damp * Time.deltaTime);

		transform.LookAt (target.transform);
	
	}
}
