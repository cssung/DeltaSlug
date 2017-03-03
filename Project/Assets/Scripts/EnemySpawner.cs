using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {
	public GameObject enemyType;    //must be set in inspector
	public float spawnInterval;	    //must be set in inspector
	public int maxSpawnsAllowed;    //must be set in inspector

	private float dt;
	private int amountSpawned;
	private Transform trans;

	void Start () {
		dt = 0;
		amountSpawned = 0;
		trans = GetComponent<Transform>();
		GetComponent<EnemySpawner>().enabled = false;	
	}
	
	void Update () {
		if (dt <= 0 && amountSpawned < maxSpawnsAllowed) {
			spawn();
		}
		else if(dt > 0) {
			dt -= Time.deltaTime;
		}

		if (amountSpawned >= maxSpawnsAllowed) {
			Destroy(gameObject);
		}
	}

	public void spawn() {
		GameObject enemyInstance = Instantiate(enemyType, 
		                                       trans.position, 
		                                       trans.rotation)as GameObject;
		
		dt = spawnInterval;
		amountSpawned++;
	}
}
