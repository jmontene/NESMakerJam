using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NESObject {

	public float speed = 1f;
	public float jumpForce = 1000f;
	public Vector2 directionalInput;


	public override void Refresh(float deltaTime){
		ProcessInput ();
		base.Refresh (deltaTime);
	}

	void ProcessInput(){
		directionalInput = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		xVelocity = directionalInput.x * speed;

		if (Input.GetButtonDown ("A")) {
			Jump ();
		}
	}

	void Jump(){
		rb.AddForce (Vector2.up * jumpForce);
	}
}
