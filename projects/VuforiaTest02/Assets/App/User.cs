using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour {
	public GameObject sofaPrefab;
	public GameObject tablePrefab;
	public GameObject vasePrefab;
	public GameObject bedPrefab;
	public GameObject cabinetPrefab;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touches.Length != 0) {
			Touch touch = Input.touches [0];
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (touch.position);
			if (Physics.Raycast (ray, out hit) && touch.phase == TouchPhase.Began) {
				if (hit.collider.gameObject.name == "AddSofa") {
					addSofa ();	
				}

				if (hit.collider.gameObject.name == "AddTable") {
					addTable ();	
				}

				if (hit.collider.gameObject.name == "AddVase") {
					addVase ();	
				}

				if (hit.collider.gameObject.name == "AddBed") {
					addBed ();	
				}

				if (hit.collider.gameObject.name == "AddCabinet") {
					addCabinet ();	
				}
			}
		}
	}

	void addSofa() {
		Instantiate (sofaPrefab);
	}

	void addTable() {
		Instantiate (tablePrefab);
	}

	void addVase() {
		Instantiate (vasePrefab);
	}

	void addBed() {
		Instantiate (bedPrefab);
	}

	void addCabinet() {
		Instantiate (cabinetPrefab);
	}
}
