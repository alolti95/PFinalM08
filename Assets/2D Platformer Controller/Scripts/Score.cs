using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {


	public Text text;
	public int score;
	// Use this for initialization
	void Start () {
		
		UpdateScore ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int newScoreValue){
		score += newScoreValue;
		UpdateScore ();
	}

	void UpdateScore(){
		text.text = "" + score;
	}
}
