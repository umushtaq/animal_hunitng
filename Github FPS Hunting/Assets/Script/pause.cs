using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using admob;
//using UnityEngine.Advertisements;
//using UnityEngine.Advertisements;
public class pause : MonoBehaviour {
	//public GameObject pauseScreen;
    public static GameObject plyr;
	public static GameObject tym;
    public static bool istru;
   // public GameObject voice;
    void Start  () {
//		Advertisement.Initialize ("1552332"); //unity ad initialization
//		Admob.Instance ().initAdmob ("ca-app-pub-8324852512321209/1119192245.","ca-app-pub-8324852512321209/6231918128");  //ad mob initialization
//		Admob.Instance ().showBannerRelative 
//		(AdSize.Banner,AdPosition.TOP_RIGHT,0);//show banner 
//		Admob.Instance ().loadInterstitial (); //ad mob int loads

        istru = false;

        plyr = GameObject.FindGameObjectWithTag("Player");
	//	tym = GameObject.FindGameObjectWithTag("time");
		Debug.Log("find");
     //   plyr.GetComponent<Rigidbody>().isKinematic = false;
    }


    void Update () {
        if (istru)
        {
           
         //   plyr.GetComponent<Rigidbody>().isKinematic = true;
			tym.GetComponent<Timer>().enabled = false;
		//	plyr.gameObject.transform.Find(gameObject.name="All Audio Sources").gameObject.SetActive(false);

        }
        

    }
	public void PauseButton(){
        istru = true;
	GameManager.Instance.PauseDialogue.SetActive (true);
//		if (Admob.Instance ().isInterstitialReady ()) {
//			Admob.Instance ().showInterstitial ();
//		} else if (Advertisement.IsReady ()) {
//			Advertisement.Show ();
//		} else if (StartAppWrapperiOS.isAdReady ()) {
//			StartAppWrapperiOS.showAd ();
//		}

    }
}
