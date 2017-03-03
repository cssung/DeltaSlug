using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Destroy(other.gameObject);
			Destroy(gameObject);
		}

		if (other.tag == "Obstacles") {
			Destroy(gameObject);
		}
	}
	
}
