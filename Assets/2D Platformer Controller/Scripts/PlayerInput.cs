using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player player;
	private bool facingRight;
	public Animator anim;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        if (Input.GetButtonDown("Jump"))
        {
            player.OnJumpInputDown();

			//System.Console.WriteLine ("saltar");
        }

        if (Input.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }
		if(Input.GetKey("w"))
		{
			anim.Play("AnimacioAmuntIdle");
		}
		if(Input.GetKey("a"))
		{
			anim.Play("AnimacioMouEsq");
		}
		if(Input.GetKey("d"))
		{
			anim.Play("AnimacioCorreDreta");
		}
		if(Input.GetKey("s"))
		{
			anim.Play("AnimacioAvaixIdle");
		}

		if(Input.GetKey("space"))
		{
			Debug.Log ("saltar");
			anim.Play("AnimSaltDreta");
		}

		if (Input.GetKeyUp ("d") || Input.GetKeyUp ("s") || Input.GetKeyUp ("w")) {
			anim.Play ("Idle");		
		}
		if (Input.GetKeyUp ("a")) {
			anim.Play ("IdleEsq");
		}
    }

	void OnCollisionEnter2D(Collision2D col){
		if (anim.GetCurrentAnimatorStateInfo(0).IsName("AnimSaltDreta")) {
			anim.Play("Idle");
		}

	}


}
