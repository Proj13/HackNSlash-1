using UnityEngine;
using System.Collections;

public class enemyAnim : MonoBehaviour {

	Animator anim;
	//int jumpHash = Animator.StringToHash("Jump");

	bool facingRight = true;
	
	
	
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	
	void Update ()
	{
		
		//if(Input.GetKeyDown (KeyCode.E)){
			//anim.SetBool (stabHash, true);

	}
	
	void Flip()
	{
		// Switch the way the player is labelled as facing
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	
}