using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Teleporter : MonoBehaviour {

	public GameObject teleportOutLocation;
	public float Red = 1.0f;
	public float Green = 0.0f;
	public float Blue = 0.0f;
	
	
	void Start () {
	
		
		if (teleportOutLocation == null) {
			Debug.LogWarning("No Teleporter Out Location has been set for " + transform.name + ", Please set it and restart");
		}

		 
		if (!GetComponent<Collider> ().isTrigger){
			Debug.LogWarning("Collider on " + transform.name + " is not set to \"Is Trigger\", please update and restart");
		}
	}

	
	void OnTriggerEnter(Collider collidedObject) {
		Debug.Log ("Player Teleported");
		
		if (collidedObject.gameObject.tag == "Player") {

			collidedObject.transform.position = teleportOutLocation.transform.position;

		}
	}

	
	void OnDrawGizmos()
	{
		Gizmos.DrawLine(transform.position,teleportOutLocation.transform.position);
	}
}
