using UnityEngine;
using System.Collections;

//Attch to gunbarrelend
//shot = Grenade prefab
//shotspawn = GunBarrelEnd

public class PlayerGrenade : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float timeBetweenShots = 1f;
	
	private float timer;

	Collider2D explosionradius;

	void Start()
	{
		explosionradius = gameObject.GetComponent<CircleCollider2D>();
	}

	void Update () 
	{
		timer += Time.deltaTime;

		if (Input.GetButtonDown ("Fire2") && timer >= timeBetweenShots && GrenadeAmount.numOfGrenades > 0) //KEYDOWN VS BUTTONDOWN
		{
			Shoot();

		}
	}
	
	public void Shoot()
	{
		timer = 0f;
		Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		GrenadeAmount.numOfGrenades --;
		Debug.Log("grenada");
	}



}
