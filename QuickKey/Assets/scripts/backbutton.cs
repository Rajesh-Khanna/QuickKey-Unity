using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class backbutton : MonoBehaviour {

	public void changeScene(int changeTheScene){
		SceneManager.LoadScene (changeTheScene);
	}
}
