using System.Collections;
using UnityEngine;

public class fallingPlatform : MonoBehaviour {

	public float fallTime=2;
	private Rigidbody2D platform;

	// Use this for initialization
	void Start () {
		platform = GetComponent<Rigidbody2D> ();
	}

	IEnumerator platformShake(float fallTime){
		while (fallTime > 0) {
			platform.position = new Vector2(platform.position.x + (Random.insideUnitCircle.x * 0.05f), platform.position.y);
			yield return new WaitForSeconds(0.0001f);
			fallTime -= Time.deltaTime;
		}
		platform.isKinematic = false;
	}
	
	void OnTriggerEnter2D(Collider2D col){
		StartCoroutine (platformShake (fallTime));
	}
}
