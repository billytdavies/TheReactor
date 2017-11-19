using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyF : MonoBehaviour {
	private bool inRange; 
	private bool notWandering = true;
	public GameObject Player;
	// Use this for initialization
	void Start () {
	Player = GameObject.FindWithTag("Player");
		if(!inRange){
			StartCoroutine(Wander());			
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		inRange = transform.Find("Radius").gameObject.GetComponent<EnemyRadius>().inRange;
		if(!inRange){
			if(notWandering){
				StartCoroutine(Wander());
				notWandering = false;
			}
		} else {
			StopCoroutine(Wander());
			transform.LookAt(Player.transform);
			transform.rotation = Quaternion.Euler(new Vector3 (0,transform.eulerAngles.y,0));
		}
			transform.position += transform.forward * 0.06f;
	}
	IEnumerator Wander(){
		transform.rotation = Quaternion.Euler(new Vector3 (transform.eulerAngles.x,Random.Range(-360f,360f),transform.eulerAngles.z));
		yield return new WaitForSeconds(3f);
		StartCoroutine(Wander());
	} 
}
