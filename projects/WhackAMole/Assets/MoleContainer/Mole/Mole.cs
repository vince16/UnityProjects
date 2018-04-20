using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour {

	// Use this for initialization
	public float visibleHeight = 0.3f;
	public float invisibleHeight = -0.6f;
	public float speed = 4f;
	public float timer = 0f;
	public float riseTime = 1.25f;

	private Vector3 targetPosition;
	private bool isHidden;

	void Awake () {
		targetPosition = new Vector3 (
			transform.localPosition.x,
			invisibleHeight,
			transform.localPosition.z
		);
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			hide ();
		}
		transform.localPosition = Vector3.Lerp (transform.localPosition, targetPosition, Time.deltaTime * speed);

	}

	public void hide() {
		targetPosition = new Vector3 (
			transform.localPosition.x,
			invisibleHeight,
			transform.localPosition.z
		);
	}

	public void hit() {
		hide ();
	}

	public void rise() {
		timer = riseTime;
		targetPosition = new Vector3 (
			transform.localPosition.x,
			visibleHeight,
			transform.localPosition.z
		);
	}
}
