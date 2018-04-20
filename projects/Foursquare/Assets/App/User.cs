using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour {
	public GameObject venuePrefab;
	public static List<Venue> venues;

	void Start () {
		venues = new List<Venue> ();	
	}

	public void instantiate() {
		for (int i = 0; i < venues.Count; i++) {
			GameObject prefabInstance = GameObject.Instantiate( venuePrefab ) as GameObject;
			if (prefabInstance != null) {
				var venueScript = prefabInstance.GetComponent<VenueComponent> ();
				if (venueScript != null) {
					venueScript.venue = venues[i];
					venueScript.instantiate ();
				} else {
					Debug.Log ("Script is null");
				}
			} else {
				Debug.Log ("Prefab is null");
			}
		}
	}

	void Update () {

	}
}
