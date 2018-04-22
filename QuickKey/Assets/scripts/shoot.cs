using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class shoot : MonoBehaviour {
	private Transform spawnPos;
	public GameObject spawnee;
	public GameObject ball1;
	public GameObject ball2;
	public GameObject ball3;
	private GameObject gob;
	//private Rigidbody2D rigidbody; 

	// Use this for initialization
	char c1, c2, c3;

	void Start () {
		gob = GameObject.Find ("gun");
	//	rigidbody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () {
		c1 = managclas.LettersOnScreen [0];
		c2 = managclas.LettersOnScreen [1];
		c3 = managclas.LettersOnScreen [2];
		//foreach(KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
		for (char c = 'A'; c <= 'Z'; c++)
		{
			if (Input.GetKeyDown ((KeyCode) System.Enum.Parse(typeof(KeyCode), ""+c)) && !Input.GetKeyDown (KeyCode.Space)) {
				if (c == Char.ToUpper (c1)) {
					managclas.LettersOnScreen [0] = ' ';
					fire (1);
				} else if (c == Char.ToUpper (c2)) {
					managclas.LettersOnScreen [1] = ' ';
					fire (2);
				} else if (c == Char.ToUpper (c3)) {
					managclas.LettersOnScreen [2] = ' ';
					fire (3);
				}
			}
		}
	}

	void fire(int loc){
		managclas.score++;;
		float directionVector =90;			
		switch (loc) {
		case 1:
			directionVector = (ball1.transform.position.y - gob.transform.position.y)/(ball1.transform.position.x - gob.transform.position.x);
			break;
		case 2:
			directionVector = (ball2.transform.position.y - gob.transform.position.y)/(ball2.transform.position.x - gob.transform.position.x);
			break;
		case 3:
			directionVector = (ball3.transform.position.y - gob.transform.position.y)/(ball3.transform.position.x - gob.transform.position.x);
			break;
		}
		directionVector = Mathf.Rad2Deg * Mathf.Atan (directionVector);
		Debug.Log (directionVector);
		if (directionVector < 0)
			directionVector = directionVector-180;
		gob.transform.rotation = Quaternion.Euler(0,0,directionVector);
		spawnPos = transform;
		Instantiate (spawnee, spawnPos.position, spawnPos.rotation);
	}
}

	/*
	public static float angl = 90f;
	public float speedz = 1.5f;
	//private Rigidbody2D rigidbody; 

	// Use this for initialization
	void Start () {
	//	rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.eulerAngles.z < 10 || transform.eulerAngles.z > 170) {
			speedz = -speedz;
		}
		transform.Rotate (0, 0, speedz);
		angl = transform.eulerAngles.z;
	}
}
*/