using UnityEngine;
using System.Collections;

public class PositionChange : MonoBehaviour {

	public Transform[] positions;
	private int actualPosition;

	public float smoothTime;
	private CameraFollow cameraFollow;

	private bool following;
	private Quaternion initialRotation;

	// Use this for initialization
	void Start () {
		actualPosition = 0;
		following = false;
		cameraFollow = this.GetComponent<CameraFollow> () as CameraFollow;
		initialRotation = this.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position != positions[actualPosition].position){
			Vector3 pos = this.transform.position;
			this.transform.position = Vector3.Lerp(pos, positions[actualPosition].position, smoothTime * Time.deltaTime);
		}
	}

	public void moveToNextPoint(){
		if(actualPosition < 4){
			actualPosition += 1;
		}
		if(actualPosition == 4 && !following)
		{
			following = true;
			cameraFollow.enabled = true;
			cameraFollow.transform.position = cameraFollow.target.transform.position - (cameraFollow.target.transform.forward * cameraFollow.distance);
			cameraFollow.transform.rotation = cameraFollow.target.transform.rotation;
			cameraFollow.height = -3;
		}
	}

	public void moveToPreviousPoint(){
		if(actualPosition > 0){
			actualPosition -= 1;
		}
		if(actualPosition == 3){
			following = false;
			this.transform.rotation = initialRotation;
			cameraFollow.enabled = false;
		}
	}
		
}
