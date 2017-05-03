using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour {

	/*void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Player") {
			Destroy (GameObject);
			//Destroy (col.gameObject);
				//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			
		}
	}*/
	public Transform startLocation;

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			transform.position = startLocation.position;
			//Destroy (col.gameObject);
			//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);


		}
	}


}
