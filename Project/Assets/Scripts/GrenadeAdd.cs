using UnityEngine;
using System.Collections;

//ADD this to grenadeItempickup
public class GrenadeAdd : MonoBehaviour {


	bool pickup;
	// Use this for initialization
	void Start () {
		//pickup = false;
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {
			//pickup = true;
			GrenadeAmount.numOfGrenades++;
			Destroy (this.gameObject);
		}


	}


}
