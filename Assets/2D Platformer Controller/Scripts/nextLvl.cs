using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLvl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnColliderEnter2D(Collider2D col){
		Debug.Log ("basura");
		if (col.tag.Equals ("Player"))
			Application.LoadLevel ("titol");
	}
}
