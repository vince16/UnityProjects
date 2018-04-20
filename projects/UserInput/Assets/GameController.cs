using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public Cube cube;

	// Use this for initialization
	void Start () {
		cube = Instantiate (cube);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("up")) {
			cube.moveUp ();
		} else if (Input.GetKey ("left")) {
			cube.moveLeft ();
		} else if (Input.GetKey ("right")) {
			cube.moveRight ();
		}
		else if (Input.GetKey ("down")) {
			cube.moveDown ();
		}
	}
}
 