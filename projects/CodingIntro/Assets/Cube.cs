using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour {

	public float sizeModifier = 0.0f;
	public string newName = "New Name";
	public bool isOpen = false;

	// Use this for initialization
	void Start () {
		transform.localScale *= sizeModifier;
		transform.localEulerAngles = Vector3.one * 45; 
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.one * sizeModifier;
	}
}
