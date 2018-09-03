using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player {

	public CharacterController2D controller;
	public float runSpeed = 40f;
	float horizontalMove = 0f;

	bool jump = false;
	bool crouch = false;

	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
		if(horizontalMove < 0)
			facingRight = false;
		else
			facingRight = true;


		shot.direction = facingRight;
		
		Debug.Log("horizontalMove" + horizontalMove);


		if(Input.GetButtonDown("Jump"))
		{
			jump = true;
		}

		if(Input.GetButtonDown("Crouch"))
		{
			crouch = true;
		} else if (Input.GetButtonUp("Crouch")) 
		{
			crouch = false;
		}
	}


	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	void FixedUpdate()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, false/*crouch*/, jump);
		jump = false;
	}

	// Collision function for non-health objects such as platforms and blocks
	/*private void OnTriggerEnter2D(Collider2D other)
    {

	}*/
}
