using System.Collections.Generic;
using UnityEngine;
using System.Collections;

using UnityEngine.UI;
public class Timer : MonoBehaviour {
	
	public float myTime;
	public Text timertxt;
	int addd;
	public static GameObject plyr;
	// Use this for initialization
	void Start () {
		
		addd = 0;
		myTime = GameManager.Instance.timervalue;
		print ("my time "+ myTime);
		plyr = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		TimerFunction ();
	}



	void TimerFunction()
	{
		int minutes = (int)myTime / 60;
		int second = (int)myTime % 60;
		timertxt.text = minutes.ToString()+" : " + second.ToString();
		myTime = myTime - Time.deltaTime;


		if (myTime <= 0) {
			GameManager.Instance.gameOverDialogue.SetActive (true);
			pause.tym.GetComponent<Timer>().enabled = false;
	//		plyr.gameObject.transform.Find(gameObject.name="All Audio Sources").gameObject.SetActive(false);

			timertxt.text = "00"+" : " + "00";
			if (addd == 0) {
//				if (Admob.Instance().isInterstitialReady()) {
//					Admob.Instance().showInterstitial();
//				}
//				else if (Advertisement.IsReady ()) {
//					Advertisement.Show ();
//				}else if(StartAppWrapperiOS.isAdReady()){
//					StartAppWrapperiOS.showAd ();
//				}
				addd = 1;
				//AdsController.instance.ShowUnityAd ();
				//AdsController.instance.showAdmobInter ();
			}

		} else 
		{
			if (minutes <= 9) {
				if (second <= 9) 
				{
					timertxt.text = "0" + minutes.ToString () + " : 0" + second.ToString ();
				} else
				{
					timertxt.text = "0" + minutes.ToString () + " : " + second.ToString ();
				}
			} else 
			{
				if (second <= 9) 
				{
					timertxt.text = "" + minutes.ToString () + " : 0" + second.ToString ();
				} else
				{
					timertxt.text = "" + minutes.ToString () + " : " + second.ToString ();
				}
			}


		}

	}

}