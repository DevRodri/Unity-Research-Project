using UnityEngine;
using System.Collections;

public class PositionChange : MonoBehaviour {

	public Transform[] positions;
	private int actualPosition;

	public float smoothTime;
	

	// Use this for initialization
	void Start () {
		actualPosition = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position != positions[actualPosition].position){
			Vector3 pos = this.transform.position;
			this.transform.position = Vector3.Lerp(pos, positions[actualPosition].position, smoothTime * Time.deltaTime);
		}
	}

	public void moveToNextPoint(){
		if(actualPosition < 3){
			actualPosition += 1;
		}
	}

	public void moveToPreviousPoint(){
		if(actualPosition > 0){
			actualPosition -= 1;
		}
	}
}
