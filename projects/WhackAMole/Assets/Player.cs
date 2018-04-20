using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private int totalScore;
	// Use this for initialization
	void Start () {
		totalScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if (Input.GetKeyDown ("space")) {
			if (Physics.Raycast (transform.position, transform.forward, out hit)) {
				if (hit.transform.GetComponent<Mole> () != null) {
					hit.transform.GetComponent<Mole> ().hit ();
					totalScore += 1;
					Debug.Log (totalScore);
				}
			}
		}
	}
}
