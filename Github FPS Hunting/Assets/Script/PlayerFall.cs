using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using admob;
//using UnityEngine.Advertisements;
public class PlayerFall : MonoBehaviour {

	private bool ads;
	// Use this for initialization
	void Start () {
//		Advertisement.Initialize ("1552332"); //unity ad initialization
//		Admob.Instance ().initAdmob ("ca-app-pub-8324852512321209/1119192245.","ca-app-pub-8324852512321209/6231918128");  //ad mob initialization
//		Admob.Instance ().showBannerRelative 
//		(AdSize.Banner,AdPosition.TOP_RIGHT,0);//show banner 
//		Admob.Instance ().loadInterstitial (); //ad mob int loads

		ads = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -50f) {
			GameManager.Instance.gameOverDialogue.SetActive (true);
			if (!ads) {
//				if (Admob.Instance ().isInterstitialReady ()) {
//					Admob.Instance ().showInterstitial ();
//				} else if (Advertisement.IsReady ()) {
//					Advertisement.Show ();
//				} else if (StartAppWrapperiOS.isAdReady ()) {
//					StartAppWrapperiOS.showAd ();
//				}
				ads = true;
			}

		}


		}
		
	}
