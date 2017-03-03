﻿using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
	public float shotLife;
	public Animator anim;

	private GameObject player;
	private LevelManager levelManager;

	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
		player = GameObject.FindGameObjectWithTag ("Player");
		anim = player.GetComponent<Animator>();
		Destroy (gameObject, shotLife);
	}

	void OnTriggerEnter2D(Collider2D other) { 

		if (other.gameObject.name == "Player") {
			if(!levelManager.isDead)
			{
				Destroy (gameObject);
				levelManager.isDead = true;
				levelManager.RespawnPlayer();
			}
		}
		
	}
}