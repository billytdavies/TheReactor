using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton("Fire2")){
			transform.localPosition = new Vector3 (0,-0.15f,1);
		}
		else{
			transform.localPosition = new Vector3 (0.5f,-0.25f,0.25f);
		}
	}
}
