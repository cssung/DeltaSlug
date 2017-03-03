using UnityEngine;
using System.Collections;

//This is for default gun. It has infinite ammo
public class PlayerShooting : MonoBehaviour {

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
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);


}
}
