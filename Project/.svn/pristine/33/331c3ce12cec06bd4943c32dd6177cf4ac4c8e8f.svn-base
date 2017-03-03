
	using UnityEngine;
	using System.Collections;
	
	public class wind_zone : MonoBehaviour 
{
		public float jumpForce = 1200f;
		
		// Use this for initialization
		void Start () {
		}
		
		// Update is called once per frame
		void Update () {
			
		}
		
		void OnTriggerEnter2D(Collider2D other){
			other.GetComponent<Rigidbody2D>().AddForce(new Vector2 (0f, jumpForce));
		}
}
	
