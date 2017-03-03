using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GrenadeAmount : MonoBehaviour
{
	public static int numOfGrenades;        // The player's score.
	
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		numOfGrenades = 10;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = numOfGrenades.ToString();
	}
}