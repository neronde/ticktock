using UnityEngine;
using System.Collections;
using System;

public class CogAnimator : MonoBehaviour {
	
	public Transform cog;
	public float amountToRotate;
	
	// Update is called once per frame
	void Update () {
		// Used negative speed to rotate in opposite direction
		//if ((DateTime.Now.Millisecond / 100) % 5 == 0) {
			cog.RotateAround(Vector3.zero, Vector3.up, amountToRotate);
		//}
		
	}
}