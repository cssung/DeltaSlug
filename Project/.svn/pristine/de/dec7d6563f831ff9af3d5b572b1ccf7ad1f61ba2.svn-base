using UnityEngine;
using System.Collections;

//ATTACH to player

public class WeaponPickup : MonoBehaviour {

	// Use this for initialization
	//public static Transform currentGun;
	public static string currentGun;

	public  string currWeapon()
	{
		return currentGun;
	}



	
	void Start () {

		//use to find child

		currentGun = "Pistol";
	    transform.Find("Pistol").gameObject.SetActive(true);
		transform.Find("Gun").gameObject.SetActive(false);
		transform.Find("Gun1").gameObject.SetActive(false);
		transform.Find("Gun2").gameObject.SetActive(false);

		
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "PickLazer") {

			currentGun = "Gun1";
			transform.Find("Pistol").gameObject.SetActive(false);
			transform.Find("Gun").gameObject.SetActive(false);
			transform.Find("Gun2").gameObject.SetActive(false);
			transform.Find("Gun1").gameObject.SetActive(true);
			GunAmmo.ammo1 = GunAmmo.ammo1 + 25;


		}

		if(other.tag == "PickOP")
		{
			currentGun = "Gun2";
			transform.Find("Pistol").gameObject.SetActive(false);
			transform.Find("Gun").gameObject.SetActive(false);
			transform.Find("Gun1").gameObject.SetActive(false);
			transform.Find("Gun2").gameObject.SetActive(true);
			GunAmmo.ammo2 = GunAmmo.ammo2 + 10;

		}

		if (other.tag == "PickGun") 
		{
			currentGun = "Gun";
			transform.Find("Pistol").gameObject.SetActive(false);
			transform.Find("Gun").gameObject.SetActive(true);
			transform.Find("Gun1").gameObject.SetActive(false);
			transform.Find("Gun2").gameObject.SetActive(false);
			GunAmmo.ammo3 = GunAmmo.ammo3 + 30;
		}
	}
}
