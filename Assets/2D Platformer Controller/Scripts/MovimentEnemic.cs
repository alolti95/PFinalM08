using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MovimentEnemic : MonoBehaviour {

	public float walkSpeed = 1.0f;      // Walkspeed
	public float wallLeft = 0.0f;       // Define wallLeft
	public float wallRight = 5.0f;      // Define wallRight
	float walkingDirection = 1.0f;
	Vector2 walkAmount;
	float originalX; // Original float value


	void Start () {
		this.originalX = this.transform.position.x;
	}

	// Update is called once per frame
	void Update () {
		walkAmount.x = walkingDirection * walkSpeed * Time.deltaTime;
		if (walkingDirection > 0.0f && transform.position.x >= wallRight) {
			walkingDirection = -1.0f;
		} else if (walkingDirection < 0.0f && transform.position.x <= wallLeft) {
			walkingDirection = 1.0f;
		}
		transform.Translate(walkAmount);
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag.Equals( "Player")) {
			Destroy (col.gameObject);

			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);

		}
	}
}
