using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {
	public GameObject loadingScreen;

	// Use this for initialization
	void Start () {

		OnScreenChange ();
		Invoke ("Levelsel", 3);
		Debug.Log ("Hello..........");

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnScreenChange()
	{

		loadingScreen.SetActive (true);
		//AdsController.instance.showAdmobInter ();


	}
	void Levelsel()
	{
		SceneManager.LoadScene ("LevelSelection");
	}

}
