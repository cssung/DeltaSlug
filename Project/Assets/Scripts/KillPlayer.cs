using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	public LevelManager levelManager;
	private Animator anim;

	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
		anim = GetComponent<Animator>();
	}

	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player") 
		{
			anim.SetTrigger("Dead");
			levelManager.RespawnPlayer();
		}
		else
			Destroy(other.gameObject);
	}
}
