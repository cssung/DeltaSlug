using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeManagement : MonoBehaviour
{
	private int time;        // The player's timer.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		time = 99;
	}
	
	void Start()
	{
		StartCoroutine(CountDown());
	}
	
	IEnumerator CountDown()
	{
		while(true)
		{
			text.text = time.ToString();
			yield return new WaitForSeconds(2);
			time--;
		}
	}
}