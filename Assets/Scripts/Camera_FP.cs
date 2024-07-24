using UnityEngine;
using System.Collections;

public class Camera_FP : MonoBehaviour {

	public float mouseSensitivity = 100f;
	float xRotation;
	float yRotation;

	Transform player;

	public Vector2 yMinMax = new Vector2 (-60, 60);


	// Use this for initialization
	void Start () {
		player = transform.parent.transform;
	}

	// Update is called once per frame
	void Update () {
		xRotation += Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
		yRotation += Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
		yRotation = Mathf.Clamp (yRotation, yMinMax.x, yMinMax.y);


		transform.localEulerAngles = Vector3.left * yRotation;
		player.localEulerAngles = Vector3.up * xRotation;
	}
}
