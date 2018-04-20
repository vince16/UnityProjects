using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject moleContainer;
	public float spawnDuration = 1.5f;
	private float timer;

	private Mole[] moles;
	// Use this for initialization
	void Start () {
		moles = moleContainer.GetComponentsInChildren<Mole> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			moles [Random.Range (0, moles.Length)].rise ();
			timer = spawnDuration;
		}
	}
}
