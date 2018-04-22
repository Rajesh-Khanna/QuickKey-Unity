using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadBG : MonoBehaviour {

	public Camera cam;

	// Use this for initialization
	void Start () {
		switch(menuAction.level){
		case 1:
			cam.backgroundColor = Color.blue;
			break;
		case 2:
			cam.backgroundColor = Color.yellow;
			break;
		case 3:
			cam.backgroundColor = Color.red;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
