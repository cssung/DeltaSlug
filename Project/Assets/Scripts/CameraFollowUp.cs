﻿using UnityEngine;
using System.Collections;

public class CameraFollowUp : MonoBehaviour {

	public GameObject player;
	//public float fixedDistance = -5f;
	public float smoothTime = 0.3F;
	Vector3 velocity;

	void Start()
	{
		//player = GameObject.FindGameObjectWithTag("Player");


	}
	
	void FixedUpdate ()
	{

		if (player.GetComponent<PlayerMovement> ().grounded) {
			//player current position.
			Vector3 position = player.transform.position;
		
			//camera current position;
			Vector3 oldPosition = transform.position;
		
			//move the camera position to targetposition + 5 
			//position.x = target.transform.position.x + fixedDistance;
			float distance = position.y - oldPosition.y;

			position.x = oldPosition.x;
			position.z = -10;
		
		
			if (distance > 0) {
				//Vector3 currentPosition = transform.position;
				//currentPosition.y = player.transform.position.y - fixedDistance; 
				transform.position = Vector3.SmoothDamp(oldPosition, position, ref velocity, smoothTime);
			}
		}
	}
}