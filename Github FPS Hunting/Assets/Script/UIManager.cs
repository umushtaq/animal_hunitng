using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public AudioClip ClickSound;
	public static UIManager instance;
	public GameObject mainMenu;
	public GameObject levelSelection;
	public GameObject exitGameDialague;
	public GameObject Playerpreferences;

	private int next;

	void Start () {
		
	 //	PlayerPrefs.DeleteAll ();
		next = PlayerPrefs.GetInt ("Next", 0);

		if (next == 1) {
			PlayerPrefs.SetInt ("Next", 0);
			LevelSelection ();

		} else 
		{
			PlayerPrefs.SetInt ("Next", 0);
			MainMenu ();
		}
			
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			exitGameDialague.SetActive (true);
		}
	}
	public void MainMenu()
	{
		mainMenu.SetActive (true);
		levelSelection.SetActive (false);
		exitGameDialague.SetActive (false);

	}
	public void BackToMain()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		mainMenu.SetActive (true);
		levelSelection.SetActive (false);

	}
	public void ExitYes()
	{
		Application.Quit ();
	}
	public void ExitNo()
	{
		exitGameDialague.SetActive (false);
	}
	public void ExitGame()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);

	}

	public void VehicleSelection()
	{
		mainMenu.SetActive (false);
	//	vehicleSelection.SetActive (true);
	//	vehicleSel.SetActive (true);
		levelSelection.SetActive (false);
	}
	public void LevelSelection()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		mainMenu.SetActive (false);
		levelSelection.SetActive (true);
	}
	public void LevelBack()
	{
		mainMenu.SetActive (false);
	//	vehicleSelection.SetActive (true);
		levelSelection.SetActive (false);
	//	vehicleSel.SetActive (true);
		
	}
	public void VehicleBack()
	{
	//	StartAppWrapper.loadAd ();
	//	StartAppWrapper.showAd ();
		mainMenu.SetActive (true);
	//	vehicleSelection.SetActive (false);
		levelSelection.SetActive (false);
		//vehicleSel.SetActive (false);
	}


	public void MoreBtn()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		Application.OpenURL ("");

	}
	public void RateUs()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		Application.OpenURL ("");

	}
	public void RewardedVideo()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		
	}


}
