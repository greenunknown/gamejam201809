using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	public float runSpeed = 40f;
	float horizontalMove = 0f;

	bool jump = false;

	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

		if(Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}


	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}
