using UnityEngine;
using System.Collections;

//This is for gun1
public class PlayerShootingLazer2 : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float timeBetweenShots = 1f;
	
	private float timer;
	private float nextFire;
	
	
	void Update () 
	{
		timer += Time.deltaTime;
		
		if (Input.GetButtonDown ("Fire1") && timer >= timeBetweenShots)
		{
			Shoot();
		}
	}
	
	public void Shoot()
	{
		timer = 0f;

		if (GunAmmo.ammo1 > 0) {
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		} else {
			transform.parent.Find("Pistol").gameObject.SetActive(true);
			transform.parent.Find("Gun1").gameObject.SetActive(false);
			WeaponPickup.currentGun = "Pistol";
		}

		GunAmmo.ammo1--;
	}
}
