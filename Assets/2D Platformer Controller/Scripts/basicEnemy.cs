﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basicEnemy : MonoBehaviour {

	private Rigidbody2D enemy;
	public float speed;
	public float maxSpeed;
	Vector2 move = new Vector2(1,0);

	// Use this for initialization
	void Start () {
		enemy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		enemy.position += move * speed;

		enemy.velocity = (enemy.velocity.x > maxSpeed) ? new Vector2 (maxSpeed, enemy.velocity.y) : enemy.velocity;
		enemy.velocity = (enemy.velocity.x < -maxSpeed) ? new Vector2 (-maxSpeed, enemy.velocity.y) : enemy.velocity;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
			try{
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}catch(MissingReferenceException e){
				
			}

		}
		else
			move.x *= -1;
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player")
			Destroy (this.gameObject);
	}
}
