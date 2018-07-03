using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using admob;
//using UnityEngine.Advertisements;

public class helathbar : MonoBehaviour {

	public static helathbar instance;
	public float totalhp;
	public float currhp;
	private bool ads;

	void Awake () {
		instance = this;
	}
	// Use this for initialization
	void Start () {
//		Advertisement.Initialize ("1525931"); //unity ad initialization
//		Admob.Instance ().initAdmob ("ca-app-pub-8324852512321209/3158137031","ca-app-pub-8324852512321209/2428165838");  //ad mob initialization
//		Admob.Instance ().showBannerRelative 
//		(AdSize.Banner,AdPosition.TOP_RIGHT,0);//show banner 
//		Admob.Instance ().loadInterstitial (); //admob int loads
		currhp= totalhp;
		ads = false;
	}
	
	// Update is called once per frame
	void Update () {
		 Damage();
	}

	void Damage(){
	
		currhp += .01f;
		transform.localScale = new Vector3 (1,currhp,1 );

		if (currhp >=1) {
			transform.localScale = new Vector3 (1,1,1 );
			Debug.Log ("Success");
		//	UnlockLevel ();
		//	GameManager.Instance.LevelCompleteDialogue.SetActive (true);
		
			if (!ads) {
				UnlockLevel ();
				GameManager.Instance.LevelCompleteDialogue.SetActive (true);
//				if (Admob.Instance().isInterstitialReady()) {
//					Admob.Instance().showInterstitial();
//				}
//				else if (Advertisement.IsReady ()) {
//					Advertisement.Show ();
//				}else if(StartAppWrapperiOS.isAdReady()){
//					StartAppWrapperiOS.showAd ();
//				}
				ads = true;
			}
		}
		}
	public void reset(){
		Debug.Log ("Reset");
		currhp = totalhp;
		transform.localScale = new Vector3 (1,currhp,1 );
	}

	void UnlockLevel()
	{
		int levelvalue = PlayerPrefs.GetInt ("Level", 0);
		int unlocklevel = PlayerPrefs.GetInt ("UnlockLevel", 0);

		if (levelvalue == 0 && unlocklevel==0) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 1);
		}
		if (levelvalue == 1 && unlocklevel==1) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 2);
		}
		if (levelvalue == 2 && unlocklevel==2) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 3);
		}
		if (levelvalue == 3 && unlocklevel==3) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 4);
		}
		if (levelvalue == 4 && unlocklevel==4) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 5);
		}
		if (levelvalue == 5 && unlocklevel==5) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 6);
		}
		if (levelvalue == 6 && unlocklevel==6) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 7);
		}
		if (levelvalue == 7 && unlocklevel==7) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 8);
		}
		if (levelvalue == 8 && unlocklevel==8) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 9);
		}
		if (levelvalue == 9 && unlocklevel==9) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 10);
		}
		if (levelvalue == 10 && unlocklevel==10) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 11);
		}
		if (levelvalue == 11 && unlocklevel==11) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 12);
		}
		if (levelvalue == 12 && unlocklevel==12) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 13);
		}
		if (levelvalue == 13 && unlocklevel==13) 
		{
			PlayerPrefs.SetInt ("UnlockLevel", 14);
		}




	}

}
