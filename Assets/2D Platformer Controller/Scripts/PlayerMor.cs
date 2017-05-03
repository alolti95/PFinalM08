using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMor : MonoBehaviour {

	public GameObject player;
	public Transform destination;

	void Update () {
		{
			if(player.transform.position.y < 25) {
				this.player.transform.position = destination.position;
			}
		}
	}
}