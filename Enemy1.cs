using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy1 : MonoBehaviour {
	public Rigidbody2D RB;
	public bool jumpset;

	// Use this for initialization
	void Start () {
		RB = GetComponent<Rigidbody2D> ();
		jumpset = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!jumpset) {
			Invoke ("EnemyJump", 2);
			jumpset = true;
		}
		}
	void EnemyJump (){
		RB.AddForce (Vector2.up * RB.mass*1000);
		jumpset = false;
	}
	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			SceneManager.LoadScene (1);
		}
	}

}

