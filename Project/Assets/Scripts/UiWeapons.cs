using UnityEngine;
using System.Collections;

public class UiWeapons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.Find("UiGun").gameObject.SetActive(false);
		transform.Find("UiGun2").gameObject.SetActive(false);
		transform.Find("UiGun1").gameObject.SetActive(false);
	
	}
	
	// Update is called once per frame
	void Update () {
		if(WeaponPickup.currentGun == "Gun1")
		{
			transform.Find("Pistol").gameObject.SetActive(false);
			transform.Find("UiGun").gameObject.SetActive(false);
			transform.Find("UiGun1").gameObject.SetActive(true);
			transform.Find("UiGun2").gameObject.SetActive(false);


		}

		if(WeaponPickup.currentGun == "Gun2")
		{
			transform.Find("Pistol").gameObject.SetActive(false);
			transform.Find("UiGun").gameObject.SetActive(false);
			transform.Find("UiGun2").gameObject.SetActive(true);
			transform.Find("UiGun1").gameObject.SetActive(false);

			
		}

		if(WeaponPickup.currentGun == "Pistol")
		{
			transform.Find("Pistol").gameObject.SetActive(true);
			transform.Find("UiGun").gameObject.SetActive(false);
			transform.Find("UiGun2").gameObject.SetActive(false);
			transform.Find("UiGun1").gameObject.SetActive(false);
		}

		if(WeaponPickup.currentGun == "Gun")
		{
			transform.Find("Pistol").gameObject.SetActive(false);
			transform.Find("UiGun").gameObject.SetActive(true);
			transform.Find("UiGun2").gameObject.SetActive(false);
			transform.Find("UiGun1").gameObject.SetActive(false);
			
			
		}

	
	}
}
