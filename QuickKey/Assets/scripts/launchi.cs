using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class launchi : MonoBehaviour {
	// Use this for initialization
	private float speed = 20f;
	private Rigidbody2D rigidBody;
	float angl = -30f * Mathf.Deg2Rad;
	GameObject gob;

	void Start () {
		rigidBody = GetComponent<Rigidbody2D> ();
		gob = GameObject.Find ("gun");
		angl = gob.transform.eulerAngles.z * Mathf.Deg2Rad;
		rigidBody.velocity = new Vector2 (speed*Mathf.Cos(angl),speed*Mathf.Sin(angl));
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnBecameInvisible (){
		Destroy (this.gameObject);
	}
	void OnTriggerEnter2D(Collider2D other){
		Destroy (this.gameObject);
	}
}
