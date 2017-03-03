using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	void Start()
	{
		StartCoroutine(Die());
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
		}
		StartCoroutine(Die());
	}

	private IEnumerator Die()
	{
		//anim.(GlobalSettings.animDeath1, WrapeMode.ClampForever);
		yield return new WaitForSeconds(.4f);
		Destroy(gameObject);
	}
}
