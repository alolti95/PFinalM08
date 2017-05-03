using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour {
	float timeLeft = 300.0f;

	public Text text;

	void Update()
	{
		timeLeft -= Time.deltaTime;
		text.text = ""+ Mathf.Round(timeLeft);
		if(timeLeft < 0)
		{
			Application.LoadLevel("gameOver");
		}
	}
}