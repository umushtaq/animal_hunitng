using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
public class GameManager : MonoBehaviour {
	public static GameManager Instance=null;

	public Transform []PlayerSpawnPos;
	public GameObject Player;

	private int vindex,levelValue;
	public GameObject hudsManager;
	public GameObject CF2Panel;
	public GameObject PauseDialogue,LevelCompleteDialogue,gameOverDialogue,exitGameDialague;
	public GameObject[] levels;

	public float timervalue;
	public static GameObject plyr;

	void Awake()
	{
		if (Instance == null) {
			Instance = this;
		}
		SpawnPlayer ();
		SetTimerValue();
		falseDialague ();
	}

	void falseDialague()
	{
		PauseDialogue.SetActive (false);
		LevelCompleteDialogue.SetActive (false);
		gameOverDialogue.SetActive (false);
		exitGameDialague.SetActive (false);
	}


	void SpawnPlayer()
	{
		vindex = PlayerPrefs.GetInt ("VehicleIndex");
		levelValue=PlayerPrefs.GetInt ("Level", 0);
		print ("level" + levelValue);

		foreach (GameObject go in levels) 
		{
			go.SetActive (false);
		}

		Player.transform.position = new Vector3 (PlayerSpawnPos [levelValue].transform.position.x,PlayerSpawnPos [levelValue].transform.position.y,PlayerSpawnPos [levelValue].transform.position.z);
	//	Instantiate (vehicles[vindex], PlayerPos[levelValue].position,PlayerPos[levelValue].rotation);
		levels [levelValue].SetActive (true);
	}

	void ExitGameDialogue()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			exitGameDialague.SetActive (true);
		}
	}
	public void ExitYes()
	{
		SceneManager.LoadScene ("MainMenu");
	}
	public void ExitNo()
	{
		exitGameDialague.SetActive (false);
	}

	public void ClickEvents(int name){

		switch (name) {
		case 0:
			Time.timeScale = 0;
			PauseDialogue.SetActive (true);
			break;
		case 1:
			Time.timeScale = 1;
			PauseDialogue.SetActive (false);
			pause.istru = false;
			break;
		case 2:
			Time.timeScale = 1;
			SceneManager.LoadScene ("GamePlay");
			break;
		case 3:
			Time.timeScale = 1;
			SceneManager.LoadScene ("MainMenu");
			break;
		case 4:
			PlayerPrefs.SetInt ("Level",PlayerPrefs.GetInt("Level",0)+1);
			PlayerPrefs.SetInt ("Next",1);
			SceneManager.LoadScene ("MainMenu");
			break;
		case 5:
			Application.OpenURL ("");
			break;
		
		case 6:
			Time.timeScale = 1;
			PlayerPrefs.SetInt ("Level", PlayerPrefs.GetInt ("Level", 0) + 1);
			SceneManager.LoadScene ("GamePlay");
			break;

		}
	}

	void SetTimerValue()
	{
		switch (levelValue) 
		{
		case 0:
			timervalue = 180.0f;
			break;
		case 1:
			timervalue = 200.0f;
			break;
		case 2:
			timervalue = 180.0f;
			break;
		case 3:
			timervalue = 220.0f;
			break;
		case 4:
			timervalue = 240.0f;
			break;
		case 5:
			timervalue = 240.0f;
			break;
		case 6:
			timervalue = 240.0f;
			break;
		case 7:
			timervalue = 180.0f;
			break;
		case 8:
			timervalue = 240.0f;
			break;
		case 9:
			timervalue = 300.0f;
			break;
		
		}
	}
}
