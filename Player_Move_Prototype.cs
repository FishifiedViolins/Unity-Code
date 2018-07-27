using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move_Prototype : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRIGHT = true; 
	public int playerJumpPower = 1250;
	private float moveX;

	public Transform firePoint;
	public GameObject lazer;

	// Update is called once per frame
	void Update () {
		PlayerMove ();

		if(Input.GetKeyDown(KeyCode.C))
			{
				Instantiate(lazer, firePoint.position, firePoint.rotation);
			}
	}

	void PlayerMove() {
		//Controls
		moveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown ("Jump")){
			Jump();
		}
		//Animation
		//Player Direction
		if (moveX < 0.0f && facingRIGHT == false) {
			FlipPlayer ();
		} else if (moveX > 0.0f && facingRIGHT == true) {
			FlipPlayer ();
		}
		//Physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}	
	void Jump() {
		//Jumping Code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
	}

	void FlipPlayer() {
		facingRIGHT = !facingRIGHT;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
		
}
 