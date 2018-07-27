using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerScript : MonoBehaviour {

	public float speed;

	public Player_Move_Prototype player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D>().velocity.y);

	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		
		if (other.gameObject.layer == 9) {
			Destroy (gameObject);
			Destroy (other.gameObject);
		}	
	}
}
