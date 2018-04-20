using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	private float positionMultiplier = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moveUp() {
		transform.position += Vector3.up * positionMultiplier;
	}

	public void moveRight() {
		transform.position += Vector3.right * positionMultiplier;
	}

	public void moveLeft() {
		transform.position += Vector3.left * positionMultiplier;
	}

	public void moveDown() {
		transform.position += Vector3.down * positionMultiplier;
	}
		
}
