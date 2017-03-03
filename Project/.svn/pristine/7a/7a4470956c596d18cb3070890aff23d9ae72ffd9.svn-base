using UnityEngine;
using System.Collections;

public class next_level : MonoBehaviour {

	public int Level;
	private bool playerinzone; 
	// Use this for initialization

	void Start () 
	{
		playerinzone = false;
	}
	
	// Update is called once per frame

	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.W) && playerinzone) //if playerinzone = false it works 
		{
			Application.LoadLevel(Level);
		}
	   
	}

	void OnTriggerStay2D(Collider2D other)
	{

		if(other.name == "Player")
		{
			playerinzone = true;  //this never happens for some reason
			
		}
			
	
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.name == "Player")
		{
			playerinzone = false;
			
		}
	}
}
