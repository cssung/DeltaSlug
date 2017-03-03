using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(RestartGame());

	}
	
	void Update () {
		if (Input.anyKeyDown)
		{
			Application.LoadLevel("MainMenu");
		}
	}

	IEnumerator RestartGame()
	{
		while(true)
		{
			yield return new WaitForSeconds(20);
			Application.LoadLevel("MainMenu");
		}
	}
}
