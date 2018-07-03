using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using admob;
//using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

//using UnityEngine.Advertisements;

public class LevelSelection : MonoBehaviour {

	public AudioClip ClickSound;
	public Button[] levels;
//	public GameObject left,right;
//	public GameObject progressbar;
	private int unlockLevels;
	public GameObject loding;
	public GameObject Playerpreferences;


	// Use this for initialization
	void Start () {

		loding.SetActive (false);
//		DontDestroyOnLoad(LoadingObj);
//		onClick=false;

		UnlockLevels ();
		//Advertisement.Initialize (PlayerPrefs.GetString("UnityID",""), false);
	}

//	int i=0;
	// Update is called once per frame
	void Update () {



//		if (onClick || LoadingObj.activeSelf) {
			Time.timeScale = 1;
//			loadingBar.TriggerOnComplete=true;
//			loadingBar.IncrementValue (i);
//			i++;
//		}
	}


	void loading(){
		loding.SetActive (true);
	}


	void NextLevel(){
	//	Admob.Instance().removeNativeBanner("Native2");
	//	Admob.Instance().removeNativeBanner("Native3");
		SceneManager.LoadScene ("MilitaryScene");
		//Application.LoadLevel("GamePlay");
	}
	public void SetUnlockLevel()
	{


	}

	public void UnlockLevels(){

		for(int i=0; i<levels.Length;i++){

			levels [i].interactable=false;
		}
		print ("unlocklevel :" + PlayerPrefs.GetInt ("UnlockLevel"));
		unlockLevels = PlayerPrefs.GetInt ("UnlockLevel",0);
	

		for (int i = 0; i <= unlockLevels; i++) 
		{
			
			levels [i].interactable=true;
		}

	}
		
	public void ClickEvents(int name){

		switch (name) 
		{

		case 0:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 0);
			break;
		case 1:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 1);
			break;
		case 2:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 2);
			break;
		case 3:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 3);
			break;
		case 4:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 4);
			break;
		case 5:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 5);
			break;
		case 6:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 6);
			break;
		case 7:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 7);
			break;
		case 8:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 8);
			break;
		case 9:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 9);
			break;
		case 10:
			GetComponent<AudioSource> ().PlayOneShot(ClickSound);
			PlayerPrefs.SetInt ("Level", 10);
			break;
		case 11:

			PlayerPrefs.SetInt ("Level", 11);
			break;

		}

		Invoke("loading",.1f);
	//	Invoke("NextLevel",2.5f);

	

	}





}
