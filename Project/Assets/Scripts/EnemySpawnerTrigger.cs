using UnityEngine;
using System.Collections;

public class EnemySpawnerTrigger : MonoBehaviour {

	void Start () {

	}
	
	void OnTriggerEnter2D(Collider2D other) { 
		if (other.gameObject.name == "Player") {
			GameObject spawner = gameObject.transform.parent.gameObject;
			spawner.GetComponent<EnemySpawner>().enabled = true;
			Destroy (gameObject);
		}	
	}
}
