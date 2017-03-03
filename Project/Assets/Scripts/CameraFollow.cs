using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float fixedDistance = -5f;
	
	void Update ()
	{
		//player current position.
		Vector3 position = target.position;

		//camera current position;
		Vector3 oldPosition = transform.position;

		//move the camera position to targetposition + 5 
		//position.x = target.transform.position.x + fixedDistance;
		float distance = position.x - oldPosition.x;


		if (distance > fixedDistance) {
			Vector3 currentPosition = transform.position;
			currentPosition.x = target.position.x - fixedDistance; 
			transform.position = currentPosition;
		}
	}
}
