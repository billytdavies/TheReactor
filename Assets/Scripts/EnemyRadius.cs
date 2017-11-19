using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRadius : MonoBehaviour {
	public bool inRange = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	void OnTriggerEnter(Collider other){
		if(other.transform.tag=="Player"){
			inRange = true;
		}
	}
	void OnTriggerExit(Collider other){
		if(other.transform.tag=="Player"){
			inRange = false;
		}
	}
}
