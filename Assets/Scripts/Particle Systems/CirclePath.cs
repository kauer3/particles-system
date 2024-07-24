using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CirclePath : MonoBehaviour {

	public Transform centerPoint;
	public float speed;
	public float radius;
	public bool x,y,z;

	void Start(){
		transform.position = new Vector3 (transform.position.x - radius, transform.position.y, transform.position.z);
	}

	// Update is called once per frame
	void Update () {
		if (x) {
			transform.RotateAround (centerPoint.position, transform.right, speed * Time.deltaTime);
		}
		if (y) {
			transform.RotateAround (centerPoint.position, transform.up, speed * Time.deltaTime);
		}
		if (z) {
			transform.RotateAround (centerPoint.position, transform.forward, speed * Time.deltaTime);
		}
	}
}

[CustomEditor(typeof(CirclePath))]
public class DrawCirclePath : Editor {
	void OnSceneGUI(){
		Handles.color = Color.green;
		CirclePath myObj = (CirclePath)target;
		Handles.DrawWireDisc (myObj.centerPoint.position, myObj.transform.up, myObj.radius);
	}
}
