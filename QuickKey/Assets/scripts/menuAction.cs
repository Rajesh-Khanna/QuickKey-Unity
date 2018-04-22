using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuAction : MonoBehaviour {

	public static int level = 0;
	public Text GameCount;
	private int count;
	public void setLevel(int l){
		level = l;
	}
		
	public void changeScene(int changeTheScene){
		PlayerPrefs.SetInt ("count", count);
		SceneManager.LoadScene (changeTheScene);
	}
	// Use this for initialization
	void Start () {
		Screen.SetResolution(1280, 600, true);
		count = PlayerPrefs.GetInt ("count");

		GameCount.text = "Game count : "+ ++count;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
