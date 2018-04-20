using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 0.9f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit)) {
			if (hit.transform.GetComponent<Cube> () != null) {
				hit.transform.GetComponent<Cube> ().onCubeEnter ();
			}
		}
	}
}
