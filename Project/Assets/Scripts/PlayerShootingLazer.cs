using UnityEngine;
using System.Collections;
//this is for Gun2
public class PlayerShootingLazer : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public Transform shotSpawn2;
	public Transform shotSpawn3;
	public Transform shotSpawn4;
	public Transform shotSpawn5;




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

		//If gun ammo goes to 0 turn off gun2
		if (GunAmmo.ammo2 > 0) {
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			Instantiate (shot, shotSpawn2.position, shotSpawn2.rotation);
			Instantiate (shot, shotSpawn3.position, shotSpawn3.rotation);
			Instantiate (shot, shotSpawn4.position, shotSpawn4.rotation);
			Instantiate (shot, shotSpawn5.position, shotSpawn5.rotation);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		} else {
			transform.parent.Find("Pistol").gameObject.SetActive(true);
			transform.parent.Find("Gun2").gameObject.SetActive(false);
			WeaponPickup.currentGun = "Pistol";
		}
		GunAmmo.ammo2 --;



	}

}
