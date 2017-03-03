﻿using UnityEngine;
using System.Collections;

public class MoverGrenade : MonoBehaviour {


	//ATTCH TO grenade prefab
	//mass 20 
	//gravity scale = 5
	// Use this for initialization
	//
	public GameObject Explosion;
	public GameObject player;
	public PlayerMovement playerMovement;
	private Animator anim;
	public float speedx;
	public float speedy;
	public float shotLife;

	
	void Start() {
		player = GameObject.Find("Player");
		playerMovement = player.GetComponent<PlayerMovement>();

		anim = GetComponent<Animator> ();
		anim.enabled = false;
		
		//so bullets shoot in direction player is facing
		if(playerMovement.facingRight == true)
			GetComponent<Rigidbody2D>().velocity = new Vector2( speedx, speedy);
		else if(playerMovement.facingRight == false)
			GetComponent<Rigidbody2D>().velocity = new Vector2( -speedx, speedy);
		
		Destroy (gameObject, shotLife);
	}

	void Update()
	{


	}

//	public void FixedUpdate(Collider2D other)
//	{
//		if (gameObject.tag == "Obstacles" || gameObject.tag == "Enemy") {
//			other.transform.GetComponent<CircleCollider2D> ().radius = 1.4f;
//			Debug.Log ("grenade tossed");
//			Destroy (this.gameObject);
//		}
//
//	}

	//This will work ~90% of the time
	void OnTriggerEnter2D(Collider2D other)
	{
		//Grenade suppose to explode


		//if(other.gameObject.tag == "Obstacles" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "F")
		//if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "F")
		if(other.gameObject.tag == "Obstacles" || other.gameObject.tag == "Enemy" || other.gameObject.tag == "Floor")
		{
			this.gameObject.GetComponent<CircleCollider2D>().radius = 1.6f;
			Debug.Log ("grenade tossed");
			//anim.enabled = true;
			Instantiate(Explosion, gameObject.transform.position, gameObject.transform.rotation);
			//GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
			//Destroy (gameObject);
			//GetComponent<Rigidbody2D>().isKinematic = true;
			//StartCoroutine(Die());

			//if (other.gameObject.tag == "Enemy") {
			//	Destroy (other.gameObject);
			//}
			Destroy(gameObject);

		}



//		if (other.gameObject.tag == "Enemy") {
//			Destroy (other.gameObject);
//		}
	}

	private IEnumerator Die()
	{
		//anim.(GlobalSettings.animDeath1, WrapeMode.ClampForever);
		yield return new WaitForSeconds(.4f);
		Destroy(gameObject);
	}
}


