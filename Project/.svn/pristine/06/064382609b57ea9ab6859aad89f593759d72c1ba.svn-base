using UnityEngine;
using System.Collections;

public class DisableFollowPlayer : MonoBehaviour {

	//private GameObject mainCamera;
	private GameObject mainCamera;


	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Player") {
			mainCamera.GetComponent<CameraFollow>().enabled = false;


		}
	
	}
}
