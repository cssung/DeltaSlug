using UnityEngine;
using System.Collections;

public class PlayerMelee : MonoBehaviour {
	
	GameObject gun;
	public Transform meleeCheck;
	public float meleeCheckRadius;
	public LayerMask whatIsMelee;
	
	private bool meleeRange;
	
	void Start () {
		gun = GameObject.FindGameObjectWithTag ("Gun");
	}
	
	void FixedUpdate()
	{
		//check if player is on the ground
		meleeRange = Physics2D.OverlapCircle (meleeCheck.position, meleeCheckRadius, whatIsMelee);
	}
	
	void Update(){
		
//		if (meleeRange && Input.GetKey(KeyCode.J)){
//			gun.SetActive(false);
//		}
		
		
	}
	
	
}