using UnityEngine;
using System.Collections;

public class IAOrutaka : MonoBehaviour {
	public float patrolSpeed =2.0f;
	public float patrolWaitTime =2.0f;
	public float chaseSpeed=10.0f;
	public float chaseTime=5.0f;
	public Transform[] patrolWayPoints;

	private Transform player;                               // Reference to the player's transform.
	private float chaseTimer;                               // A timer for the chaseWaitTime.
	private float patrolTimer;                              // A timer for the patrolWaitTime.
	private int wayPointIndex;                              // A counter for the way point array.
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("detectado");
	}

	void OnTriggerStay(Collider other) {
		Debug.Log ("mantenido");
	}

	// Update is called once per frame
	void Update ()
	{
		//if("enemigo a la vista")
		//	Chasing();
	
		//else
		//	Patrolling();
	}

	void Awake ()
	{
		// Setting up the references.
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	void Chasing ()
	{
			chaseTimer += Time.deltaTime;
			// If not near the last sighting personal sighting of the player, reset the timer.
			chaseTimer = 0f;
	}
	
	
	void Patrolling ()
	{


				/*	patrolTimer += Time.deltaTime;
			

			if(patrolTimer >= patrolWaitTime)
			{

				if(wayPointIndex == patrolWayPoints.Length - 1)
					wayPointIndex = 0;
				else
					wayPointIndex++;
				

				patrolTimer = 0;
			}
		}
		else

			patrolTimer = 0;

	}*/
	}
}
