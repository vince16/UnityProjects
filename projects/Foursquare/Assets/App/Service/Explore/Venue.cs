using System;
using System.Collections.Generic;

public class Venue
{
	public string id;
	public string name;
	public float lat;
	public float lng;
	public string address;

	public Venue(string id, string name, float lat, float lng, string address) {
		this.id = id;
		this.name = name;
		this.lat = lat;
		this.lng = lng;
		this.address = address;
	}
}