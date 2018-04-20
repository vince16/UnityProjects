using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenueComponent : MonoBehaviour {

	public Venue venue;

	void Start () {
		
	}

	public void instantiate() {
		if (venue != null) {
			TextMesh textMesh = (TextMesh)this.GetComponent (typeof(TextMesh));
			textMesh.text = venue.name;
			this.transform.position = new Vector3 (venue.lat, 0, venue.lng);
			this.transform.localScale *= venue.lng;
			Debug.Log ("Instantiating at : " +transform.position);
		}
	}
	

	void Update () {
		
	}
}
