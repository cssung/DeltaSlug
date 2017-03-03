	using UnityEngine;
	using System.Collections;
	
	public class zone : MonoBehaviour 
    {
		public GameObject wind_zone;

		public float jumpForce = 1200f;
		
		// Use this for initialization
		void Start () {
		}
		
		// Update is called once per frame
		void Update () {
			
		}		



//	public void OnTriggerStay2D(Collider2D other)
//	{
//		//other.GetComponent<Rigidbody2D>().transform(new Vector2 (0f, jumpForce));
//
//		//other.transform.position = Vector3.MoveTowards (platform.transform.position, currentPoint.position, Time.deltaTime * moveSpeed);
//		
//		if(platform.transform.position == currentPoint.position)
//		{
//			pointsSelection++;
//			
//			if(pointsSelection == points.Length)
//			{
//				pointsSelection = 0; // reset back to 0
//			}
//			
//			currentPoint = points[pointsSelection];
//		}
//	}



}

//11
