using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour 
{
	
	public GameObject platform;
	public float moveSpeed;
	public Transform currentPoint;
	public Transform[] points;
	public int pointsSelection;
	
	// Use this for initialization
	void Start () 
	{
		currentPoint = points[pointsSelection];
	}
	//endpoint is 1 start is 0
	// Update is called once per frame
	void Update () 
	{
		platform.transform.position = Vector3.MoveTowards (platform.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);

		if(platform.transform.position == currentPoint.position)
		{
			pointsSelection++;

			if(pointsSelection == points.Length)
			{
				pointsSelection = 0; // reset back to 0
			}
			
			currentPoint = points[pointsSelection];
		}
	}
	
}




