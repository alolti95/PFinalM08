using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour {

	public Transform target;//set target from inspector instead of looking in Update
	public float speed = 3f;
	private Rigidbody2D enemy;
	public float maxSpeed;
	Vector2 move = new Vector2(1,0);
	public Animator anim;
	void Start () {
		enemy = GetComponent<Rigidbody2D>();
	}

	void Update(){

		//rotate to look at the player
		transform.LookAt(target.position);
		transform.Rotate(new Vector3(0,-90,0),Space.Self);//correcting the original rotation


		//move towards the player
		if (Vector3.Distance(transform.position,target.position)>1f){//move if distance from target is greater than 1
			transform.Translate(new Vector3(speed* Time.deltaTime,0,0) );
		}

	}
		
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag.Equals( "Player")) {
			Destroy (col.gameObject);

			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		
		}
		else
			move.x *= -1;
	}


}