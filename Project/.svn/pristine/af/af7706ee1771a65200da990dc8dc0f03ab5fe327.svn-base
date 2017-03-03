using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
	public float respawnDelay;
	public Animator anim;
	public GameObject playerHead;
	public GameObject playerArm;
	public bool isDead;
	public GameObject player;

	private PlayerMovement playerMovement;
	private PlayerShooting playerShooting;
	private CameraFollow cameraFollow;
	
	void Start () {
		playerMovement = FindObjectOfType<PlayerMovement> ();
		playerShooting = FindObjectOfType<PlayerShooting> ();
		cameraFollow = FindObjectOfType<CameraFollow> ();
		GetComponent<CameraFollowUp>().enabled = false;
		anim = playerMovement.GetComponent<Animator>();
		playerHead = GameObject.FindGameObjectWithTag ("PlayerHead");
		playerArm = GameObject.FindGameObjectWithTag ("PlayerArm");
		player = GameObject.FindGameObjectWithTag ("Player");
		isDead = false;
	}

	void Update () {
	
	}

	public void RespawnPlayer2()
	{
		playerMovement.transform.position = currentCheckpoint.transform.position;
	}

	public void RespawnPlayer()
	{
		StartCoroutine ("RespawnPlayerCo");
	}
	

	public IEnumerator RespawnPlayerCo()
	{
		playerMovement.MoveVelocityToZero ();
		playerMovement.enabled = false;
		playerShooting.enabled = false;
		anim.SetTrigger ("Die");
		playerHead.SetActive (false);
		playerArm.GetComponent<SpriteRenderer> ().enabled = false;

		yield return new WaitForSeconds (respawnDelay);

		isDead = false;
		playerHead.SetActive (true);
		playerArm.SetActive (true);
		playerMovement.transform.position = currentCheckpoint.transform.position;
		playerMovement.enabled = true;
		playerShooting.enabled = true;
	}
}
