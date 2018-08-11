using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initializationa
	void Start () {
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(Input.inputString);
		if(Input.GetKey(KeyCode.A)){
			transform.Translate(-0.1f,0,0);
		}
		
		if(Input.GetKey(KeyCode.D)){
			transform.Translate(0.1f,0,0);
		}
		Vector2 PlayerPosition = transform.position;
		Debug.Log(Time.time); 
	}
}
