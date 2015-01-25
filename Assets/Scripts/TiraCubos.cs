using UnityEngine;
using System.Collections;

public class TiraCubos : MonoBehaviour {

	public GameObject cubo;

	public Transform pos;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("tiraCubos", 1.0f, 2.5f);
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetMouseButtonUp(0))
		{
			RaycastHit ht;
			Ray rallo = camera.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(rallo.origin, rallo.direction * 100, Color.yellow);
			if (Physics.Raycast(rallo,out ht,100.0f)){

				Vector3 posicion = new Vector3(ht.point.x, 30.0f, ht.point.z);
				
				Instantiate(cubo, posicion, Quaternion.identity);
			}
			
		}*/
	}

	void tiraCubos(){
		Vector3 newPos = pos.position;
		newPos.y = 30f;
		Instantiate(cubo, newPos, Quaternion.identity);
	}
}
