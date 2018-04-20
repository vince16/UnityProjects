using UnityEngine;
using System.Collections;

public class onClickForScaling : MonoBehaviour {
	void OnMouseDown() {
		CSharpscaling.ScaleTransform = this.transform;
		Rotate.ScaleTransform = this.transform;
	}
}