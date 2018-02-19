using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NESObject : MonoBehaviour {

	protected float xVelocity;
	protected Rigidbody2D rb;

	public virtual void Init(){
		xVelocity = 0f;
		rb = GetComponent<Rigidbody2D> ();
	}
	public virtual void Refresh(float deltaTime){
		Move (deltaTime);
	}

	void Move(float deltaTime){
		rb.velocity = new Vector2(xVelocity, rb.velocity.y);
	}
}
