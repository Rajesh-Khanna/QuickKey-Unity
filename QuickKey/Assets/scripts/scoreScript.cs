using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {
	Text scoreField;
	// Use this for initialization
	void Start () {
		scoreField = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		scoreField.text = "Score: " + managclas.score;
	}
}
