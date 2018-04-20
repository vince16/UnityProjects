using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;

public class FoursquareService : MonoBehaviour{
	private String EXPLORE_API_URL = "https://api.foursquare.com/v2/venues/explore";
	private String CLIENT_ID = "R0AN30KS33AASPJ1M3HPZ4VPMJNGGTBG1WAN5FMTUQYA5XJQ";
	private String CLIENT_SECRET = "SIVHJGO2Q5L5QBEZTUCXMR1JY2SRE0YSGBWX3LPDCUJ15PSU";
	public GameObject venuePrefab;

	public void start() {
		Debug.Log ("Venue Prefab : " + venuePrefab);
	}

	public IEnumerator callExploreApi(String lat, String lng) {
		String url = EXPLORE_API_URL + "?" +
		            "client_id=" + CLIENT_ID + "&" +
					"client_secret=" + CLIENT_SECRET + "&" +
					"v=" + "20180411" + "&" +
					"ll=" + lat + "," + lng;

		UnityWebRequest www = UnityWebRequest.Get(url);

		yield return www.SendWebRequest();

		if(www.isNetworkError || www.isHttpError) {
			Debug.Log(www.error);
			Debug.Log(www.downloadHandler.text);
		}
		else {
			List<Venue> venues = new List<Venue> ();
			var json = JSON.Parse (www.downloadHandler.text);
			var venuesJSONArray = json ["response"] ["groups"] [0] ["items"].AsArray;
			for (int i = 0; i < venuesJSONArray.Count; i++) {
				var venueJSON = venuesJSONArray [i]["venue"];
				Venue venue = new Venue (venueJSON["id"],
					venueJSON["name"],
					float.Parse(lat) - venueJSON["location"]["lat"].AsFloat,
					float.Parse(lat) - venueJSON["location"]["lng"].AsFloat,
					venueJSON["location"]["address"]);
				venues.Add (venue);
				User.venues = venues;
			}
			User userScript = Camera.main.GetComponent<User> ();
			userScript.instantiate ();
		}
	}
}