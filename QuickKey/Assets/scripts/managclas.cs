using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class managclas : MonoBehaviour {
	public string[] ans = {"Monday","Seven","Water","Pacific" };
	public string[] Ques = {"First day of the week","Number of Continent","Common name for H2O","Largest oceans" };
	public static char[] LettersOnScreen = {' ',' ',' '};
	public static int state = 0;
	public static int score = 0;
	public GameObject Ball1;
	public GameObject Ball2;
	public GameObject Ball3;
	public GameObject QField;

	public static string textObj="c1Text";
	public static string textPos="GameObject";
	public static char printWord = '#';
	public static int OnScreenwordcount = 0; 
	public Transform spawnP1;
	public Transform spawnP2;
	public Transform spawnP3;
	public GameObject spawnee2;
	private int wordlength = 0;
	private int currentWord = 0;
	private GameObject TEXT1;
	private Text txtField1;
	private GameObject TEXT2;
	private Text txtField2;
	private GameObject TEXT3;
	private Text txtField3;
	private GameObject Postemp;
	private Text QText;
	private strike ball1;
	private strike ball2;
	private strike ball3;

	// Use this for initialization
	void Start () {
		Screen.SetResolution(1280, 600, true);
		TEXT1 = GameObject.Find("c1Text");
		txtField1 = TEXT1.GetComponent<Text> ();
		TEXT2 = GameObject.Find("c2Text");
		txtField2 = TEXT2.GetComponent<Text> ();
		TEXT3 = GameObject.Find("c3Text");
		txtField3 = TEXT3.GetComponent<Text> ();
		QText = QField.GetComponent<Text> ();
		ball1 = (strike) Ball1.GetComponent(typeof(strike));
		ball2 = (strike) Ball2.GetComponent(typeof(strike));
		ball3 = (strike) Ball3.GetComponent(typeof(strike));
	}

	// Update is called once per frame
	void Update () {
		if(state == 0)
		{
			state = 1;
			currentWord = UnityEngine.Random.Range(0,ans.Length);
			wordlength = ans[currentWord].Length;
			askQ ();
			return;
		}
		if (state == 1) {
			if (Input.GetKeyDown ("space"))
				state = 2;
		}
		if (state == 2) {
			QText.text = "";
			try{
				printWord = ans [currentWord] [ans[currentWord].Length - wordlength--]; 
				OnScreenwordcount++;
			}catch{
				printWord = ' ';}  
			txtField1.text = ""+printWord;
			LettersOnScreen[0] = printWord;		
			try {
				printWord = ans [currentWord] [ans[currentWord].Length - wordlength--];
				OnScreenwordcount++;
			} catch{
				printWord = ' ';
			}	
			LettersOnScreen[1] = printWord;		
			txtField2.text = ""+printWord;

			try {
				printWord = ans [currentWord] [ans[currentWord].Length - wordlength--];
				OnScreenwordcount++;
			} catch  {
				printWord = ' ';
			}
			txtField3.text = ""+printWord;
			LettersOnScreen[2] = printWord;		
			state = 3;
			strike.act = true;
			return;

		}
		if (state == 3) {
			if (OnScreenwordcount <= 0) {
				ball1.reset();
				ball2.reset();
				ball3.reset();
				strike.act = false;
				if (wordlength > 0){
					state = 2;
				}else {
					state = 0;
				}
			}	
		}

	}
	private void askQ(){
		QText.text = Ques [currentWord]+"?"+"\n (Space) to start";
	}
}
