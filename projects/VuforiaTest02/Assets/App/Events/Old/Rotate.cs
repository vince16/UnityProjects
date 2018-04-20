using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public float initialFingersDistance;
	public Vector3 initialScale;
	public static Transform ScaleTransform;

	void  Update (){
		int fingersOnScreen = 0;

		foreach(Touch touch in Input.touches) {
			fingersOnScreen++; 
			if(fingersOnScreen == 2){
				if(touch.phase == TouchPhase.Began){
					initialFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);
					initialScale = ScaleTransform.localScale;
				}
				else{
					float currentFingersDistance = Vector2.Distance(Input.touches[0].position, Input.touches[1].position);

					float scaleFactor = currentFingersDistance / initialFingersDistance;

					ScaleTransform.Rotate (0, 0, scaleFactor);
				}
			}
		}
	}
}