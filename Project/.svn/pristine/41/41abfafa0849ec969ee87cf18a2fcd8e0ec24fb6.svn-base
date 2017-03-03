using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//

public class GunAmmo : MonoBehaviour
{
	WeaponPickup obj;
	public static float ammo; // The player's score.
	public static int   ammo1; //ammo for Gun1
	public static int   ammo2; //gun2
	public static int   ammo3; //this is for Gun
	
	Text text;                      // Reference to the Text component.
	
	
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <Text> ();
		
		// Reset the score.
		ammo = Mathf.Infinity;
		ammo1 = 0;
		ammo2 = 0;
		ammo3 = 0;
	}
	
	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		if(WeaponPickup.currentGun == "Gun1")
		{
			text.text = ammo1.ToString();
		}

		if(WeaponPickup.currentGun == "Gun2")
		{
			text.text = ammo2.ToString();
		}

		if(WeaponPickup.currentGun == "Gun")
		{
			text.text = ammo3.ToString();
		}

		if(WeaponPickup.currentGun == "Pistol")
		{
			text.text = ammo.ToString();
		}

		//text.text = ammo1.ToString ();
	}
}