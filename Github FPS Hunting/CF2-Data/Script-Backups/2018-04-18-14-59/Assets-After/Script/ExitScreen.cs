using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScreen : MonoBehaviour {

	public GameObject exitGameDialague;

	// Use this for initialization
	void Start () {
		exitGameDialague.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		ExitGameDialogue ();
		
	}

	void ExitGameDialogue()
	{
		if (ControlFreak2.CF2Input.GetKeyDown (KeyCode.Escape)) 
		{
			exitGameDialague.SetActive (true);
		}
	}
	public void ExitYes()
	{
		Application.Quit ();
		//		SceneManager.LoadScene ("LevelSelection");
	}
	public void ExitNo()
	{
		exitGameDialague.SetActive (false);
		//		BlurScreen.SetActive (false);
		//		ExitDialogue.SetActive (false);
	}
}
