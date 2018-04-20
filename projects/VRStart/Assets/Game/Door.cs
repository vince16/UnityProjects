using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	private Vector3 doorPosition;
	public Vector3 lowerDoorPosition;

	// Use this for initialization
	void Start () {
		doorPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.Lerp (transform.position, doorPosition, Time.deltaTime);
	}

	public void lowerDoor() {
		doorPosition = lowerDoorPosition;
	}
}
