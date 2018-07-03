using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	public AudioClip ClickSound;
	public static UIManager instance;
	public GameObject mainMenu;
	//public GameObject vehicleSelection;
	//public GameObject vehicleSel;
	public GameObject levelSelection;
	public GameObject Playerpreferences;
//	public VehicleSelection vehicle;
//	public Text txtTotalcash;

	private int next;
//	public string rateusLink;
//	public string moregamesLink;

	// Use this for initialization
	void Start () {
		
		next = PlayerPrefs.GetInt ("Next", 0);

		if (next == 1) {
			PlayerPrefs.SetInt ("Next", 0);
			LevelSelection ();

		} else 
		{
			PlayerPrefs.SetInt ("Next", 0);
			MainMenu ();
		}



	//	txtTotalcash.text =""+ PlayerPrefs.GetInt ("TotalCash",0);
	}
		
	public void MainMenu()
	{
//		Admob_Ads_Script.Instance.showNativeAds();
	//	Admob_Ads_Script.Instance.showNativeAds2();
	//	Admob_Ads_Script.Instance.showNativeAds3();
		mainMenu.SetActive (true);
	//	vehicleSel.SetActive (false);
	//	vehicleSelection.SetActive (false);
		levelSelection.SetActive (false);

	}
	public void BackToMain()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		mainMenu.SetActive (true);
		levelSelection.SetActive (false);

	}

	public void ExitGame()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		Application.Quit ();
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
