using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public GameObject CubePrefab;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 10; i++) {
			GameObject cubeObject = Instantiate (CubePrefab);	
			cubeObject.transform.position = new Vector3 (i * 10, i * 10, i * 10);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
