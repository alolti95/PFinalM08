using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bala : MonoBehaviour {

    public float velX = 5f;
    float velY = 0f;
    Rigidbody2D rb;
	int punt=10;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(velX, velY);
        Destroy(gameObject, 3f);
		//Debug.Log (num);
	}
}
