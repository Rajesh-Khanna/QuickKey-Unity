using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class strike : MonoBehaviour {
	public Transform spawnPos;
	public GameObject TEXT;
	private Text txtField;
	private Rigidbody2D rigidBody;
	private Vector2 speed;
	private Vector2 stop;
	public static bool act = false;
	void Start () {
		speed = new Vector2(0,-2f);
		stop = new Vector2(0,0);
		rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.velocity = stop;
		TEXT.transform.position = Camera.main.WorldToScreenPoint (spawnPos.position);
		//txtField = TEXT.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		if (act){
			rigidBody.velocity = speed;
			TEXT.transform.position = Camera.main.WorldToScreenPoint (spawnPos.position);
		}		
		TEXT.transform.position = Camera.main.WorldToScreenPoint (rigidBody.position);
		if (rigidBody.position.y < -6) {
			TEXT.transform.position = Camera.main.WorldToScreenPoint (spawnPos.position);
			rigidBody.position = spawnPos.position;
			rigidBody.velocity = stop;
			managclas.OnScreenwordcount--;
			act = false;
		}
	}

	public void reset(){
		TEXT.transform.position = Camera.main.WorldToScreenPoint (spawnPos.position);
		rigidBody.position = spawnPos.position;
		rigidBody.velocity = stop;
	}

	void OnTriggerEnter2D(Collider2D other){
		TEXT.transform.position = Camera.main.WorldToScreenPoint (spawnPos.position);
		rigidBody.position = spawnPos.position;
		managclas.OnScreenwordcount--;
		rigidBody.velocity = stop;
		act = false;

	}
}