using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public float clampOffset = 10f;
	public GameObject gun;
	public GameObject playerHead;
	public GameObject playerArm;
	public bool lookAndShootUp;
	public bool shootDown;
	public LevelManager levelManager;

	private BoxCollider2D boxCollider;

	public bool facingRight;
	public bool grounded;
	public bool crouched;
	private Animator anim;
	private float moveVelocity;
	private Vector3 pos1;

	private Vector2 originalBoxCollider;
	private float crouchHeight;
	
	private GameObject currentCheckpoint;
	
	void Start () 
	{
		anim = GetComponent<Animator> ();
		facingRight = true;
		boxCollider = gameObject.GetComponent<BoxCollider2D> ();
		originalBoxCollider = boxCollider.size;
		crouchHeight = boxCollider.size.y / 2.5f;
		gun = GameObject.FindGameObjectWithTag ("Gun");
		playerHead = GameObject.FindGameObjectWithTag ("PlayerHead");
		playerArm = GameObject.FindGameObjectWithTag ("PlayerArm");
		currentCheckpoint = GameObject.FindGameObjectWithTag ("Checkpoint");
	}

	public void MoveVelocityToZero(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
	}


	void FixedUpdate()
	{
		//check if player is on the ground
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}
	
	void Update () {

		anim.SetBool ("Grounded", grounded);
		anim.SetBool ("Crouched", crouched);

		//If player is not grounded and pressing S, shoot downwards
		if (Input.GetKey (KeyCode.S) && !grounded) {
			shootDown = true;
		} else {
			shootDown = false;
		}


		//When S button gets released
		//Return box collider back to original size
		if (Input.GetKeyUp (KeyCode.S) || !grounded) {
			boxCollider.size = originalBoxCollider;
			grounded = false;
			crouched = false;
		}

		//If the player is grounded and crouching
		//Divide box collider by crouchheight
		if (Input.GetKey (KeyCode.S) && grounded) {
			boxCollider.size = new Vector2(boxCollider.size.x, crouchHeight);
			crouched = true;
		}


		//Enable shooting up
		if (Input.GetKey (KeyCode.W)) {
			lookAndShootUp = true;
			gun.transform.rotation = Quaternion.Euler (0f, 0f, 90f);
			playerHead.transform.rotation = Quaternion.Euler (0f, 0f, 25f);
			playerArm.transform.rotation = Quaternion.Euler(0f, 0f, 75f);
			//if(Input.GetKeyDown(KeyCode.W)){
				//gun.transform.position = new Vector3(gun.transform.position.x - .4f, gun.transform.position.y + 1, 0f);
			//}
		} else {
			lookAndShootUp = false;
			gun.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
			playerHead.transform.rotation = Quaternion.Euler (0f, 0f, 0f);
			playerArm.transform.rotation = Quaternion.Euler(0f, 0f, 31f);
			//if(Input.GetKeyUp(KeyCode.W)){
				//gun.transform.position = new Vector3(gun.transform.position.x + .4f, gun.transform.position.y - 1f, 0f);
			//}
		}

		if (Input.GetButtonDown ("Jump") && grounded)
		{
			Jump();
		}

		moveVelocity = 0f;

		if (Input.GetKey (KeyCode.D))
		{
			if(Input.GetKey(KeyCode.S) && grounded)
				moveVelocity = moveSpeed/2f;
			else
				moveVelocity = moveSpeed;

			facingRight = true;
		}
		
		if (Input.GetKey (KeyCode.A))
		{
			if(Input.GetKey(KeyCode.S) && grounded)
				moveVelocity = -moveSpeed/2f;
			else
				moveVelocity = -moveSpeed;
			facingRight = false;
		}

		GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

		anim.SetFloat ("Speed", Mathf.Abs(GetComponent<Rigidbody2D> ().velocity.x));

		if (GetComponent<Rigidbody2D> ().velocity.x > 0)
			transform.localScale = new Vector3 (1f, 1f, 1f);
		else if (GetComponent<Rigidbody2D> ().velocity.x < 0)
			transform.localScale = new Vector3 (-1f, 1f, 1f);

		Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
		
		screenPos.x = Mathf.Clamp(screenPos.x, 0f + clampOffset, Screen.width - clampOffset);
		
		transform.position = Camera.main.ScreenToWorldPoint(screenPos);

		if (grounded) {
			Vector2 pos = currentCheckpoint.transform.position;
			pos.x = groundCheck.position.x;
			pos.y = 3 + groundCheck.position.y;
			currentCheckpoint.transform.position = pos;
		}

		//If player moves out of camera view respawn.
		if(!GetComponent<Renderer>().isVisible)
		{

			gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			gameObject.transform.position = currentCheckpoint.transform.position;

		}
		
	}

	public void Jump()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}

	//put in player put player as child
	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.transform.tag == "MovingPlatform")
		{
			transform.parent = other.transform;
		}
	}
	
	void OnCollisionExit2D(Collision2D other)
	{
		if(other.transform.tag == "MovingPlatform")
		{
			transform.parent = null;
		}
	}



}








