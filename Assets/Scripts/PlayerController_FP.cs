using UnityEngine;
using System.Collections;

public class PlayerController_FP : MonoBehaviour {

	public float walkSpeed = 3f;
	public bool isWalking;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		Vector3 inputDirection = input.normalized;

		transform.Translate (inputDirection * walkSpeed * Time.deltaTime);

		if (input.magnitude > 0) {
			isWalking = true;
		} else {
			isWalking = false;
		}
	}
}