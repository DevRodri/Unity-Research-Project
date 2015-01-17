using UnityEngine;
using System.Collections;

public class TiraCubos : MonoBehaviour {

	public GameObject cubo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonUp(0))
		{
			RaycastHit ht;
			Ray rallo = camera.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(rallo.origin, rallo.direction * 100, Color.yellow);
			if (Physics.Raycast(rallo,out ht,100.0f)){

				Vector3 posicion = new Vector3(ht.point.x, 60.0f, ht.point.z);
				
				Instantiate(cubo, posicion, Quaternion.identity);
			}
			
		}
	}
}
