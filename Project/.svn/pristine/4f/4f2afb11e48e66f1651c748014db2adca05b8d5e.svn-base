using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public GameObject player;
	public PlayerMovement playerMovement;
	public float speed;
	public float shotLife; 
	
	void Start() {
		player = GameObject.Find("Player");
		playerMovement = player.GetComponent<PlayerMovement>();


		if (playerMovement.lookAndShootUp) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 0f, 90f);
			GetComponent<Rigidbody2D> ().velocity = transform.right * speed;
		}
		else if (playerMovement.shootDown) {
			gameObject.transform.rotation = Quaternion.Euler (0f, 0f, 90f);
			GetComponent<Rigidbody2D> ().velocity = -transform.right * speed;
		}
		else {
			//so bullets shoot in direction player is facing
			if (playerMovement.facingRight == true)
				GetComponent<Rigidbody2D> ().velocity = transform.right * speed;
			else if (playerMovement.facingRight == false)
				GetComponent<Rigidbody2D> ().velocity = -transform.right * speed;
		}
		Destroy (gameObject, shotLife);
	}
}
