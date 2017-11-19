using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
	public GameObject bulletpre;
	private bool canshoot= true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			if(canshoot){
				StartCoroutine(shoot());
			}
		}	
	}
	IEnumerator shoot(){
		var bullet = Instantiate(bulletpre,transform.position,transform.rotation);
		bullet.GetComponent<Rigidbody>().velocity += transform.up*30;

		
		Destroy(bullet,4f);
		
		canshoot = false;
		yield return new WaitForSeconds(0.5f);
		canshoot = true;
	}
}
