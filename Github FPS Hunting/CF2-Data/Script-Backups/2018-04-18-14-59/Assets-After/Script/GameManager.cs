using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;
//using admob;
//using UnityEngine.Advertisements;
//using UnityEngine.Advertisements;
public class GameManager : MonoBehaviour {
	public static GameManager Instance;

	public GameObject[] PlayerPos;
	//public GameObject Player;
	//public GameObject[] vehicles;
	//public GameObject[] Tracks;
	//public RCC_Camera camera;
	private int vindex,levelValue;
	public GameObject PauseDialogue,LevelCompleteDialogue,gameOverDialogue,exitGameDialague;
	public GameObject[] levels;
//	public GameObject[] finish;
	//public GameObject[] Directions;
	public float timervalue;
	public static GameObject plyr;


	// Use this for initialization
	void Awake()
	{
		
		SpawnPlayer ();
		SetTimerValue();
		falseDialague ();
		Instance = this;


	}
	void Start () {

		falseDialague ();
		Debug.Log ("Awake");
		plyr = GameObject.FindGameObjectWithTag("Player");

		
	}




	
	// Update is called once per frame
	void Update () {

		ExitGameDialogue ();
		
	}

	void falseDialague()
	{
		print ("Game Manager");
		PauseDialogue.SetActive (false);
		LevelCompleteDialogue.SetActive (false);
		gameOverDialogue.SetActive (false);
		exitGameDialague.SetActive (false);
	}


	void SpawnPlayer()
	{
		vindex = PlayerPrefs.GetInt ("VehicleIndex");

		print ("Vindex" + vindex);
		levelValue=PlayerPrefs.GetInt ("Level", 0);
		print ("level" + levelValue);

		Debug.Log ("Level Value = " + levelValue);

		foreach (GameObject go in PlayerPos) 
		{
			go.SetActive (false);
		}

		foreach (GameObject go in levels) 
		{
			go.SetActive (false);
		}
//		foreach (GameObject go in finish) 
//		{
//			go.SetActive (false);
//		}
		Debug.Log ("Level Value :" + levelValue);



			

	//	Instantiate (vehicles[vindex], PlayerPos[levelValue].position,PlayerPos[levelValue].rotation);
		PlayerPos [levelValue].SetActive (true);
		levels [levelValue].SetActive (true);
//		finish [levelValue].SetActive (true);
	//	Directions [levelValue].SetActive (true);
//		RadarController.Instance.SetLookTarget(levels[levelValue].transform);
	//	LookAtTargetController.transform.LookAt(levels[levelValue].transform);

		//Barrier [levelValue].SetActive (true);
		//Barrier [7 - levelValue].SetActive (true);
	//	busStops [levelValue].SetActive (true);


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

			PauseDialogue.SetActive (false);
			pause.istru = false;
		//	pause.plyr.GetComponent<Rigidbody>().isKinematic = false;
		//	pause.tym.GetComponent<Timer>().enabled = true;
	//		plyr.gameObject.transform.Find(gameObject.name="All Audio Sources").gameObject.SetActive(true);

			break;
		case 2:
			SceneManager.LoadScene ("GamePlay");
			break;
		case 3:

			SceneManager.LoadScene ("MainMenu");
			break;
		case 4:
	
			PlayerPrefs.SetInt ("Level",PlayerPrefs.GetInt("Level",0)+1);
			PlayerPrefs.SetInt ("Next",1);
			SceneManager.LoadScene ("MainMenu");
			break;
		case 5:
			Application.OpenURL ("itms-apps://itunes.apple.com/app/idcom.finex.passenger.jetski.3D");

			break;
			
		}

		}

	void SetTimerValue()
	{
		switch (levelValue) 
		{
		case 0:
			timervalue = 30.0f;
			break;
		case 1:
			timervalue = 60.0f;
			break;
		case 2:
			timervalue = 90.0f;
			break;
		case 3:
			timervalue = 120.0f;
			break;
		case 4:
			timervalue = 180.0f;
			break;
		case 5:
			timervalue = 40.0f;
			break;
		case 6:
			timervalue = 80.0f;
			break;
		case 7:
			timervalue = 120.0f;
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
