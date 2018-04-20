using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private float shootingForce = 200000f;

	void Start () {
		GetComponent<Rigidbody> ().AddForce (Vector3.forward * shootingForce);
	}
	
	void Update () {
		
	}
}
