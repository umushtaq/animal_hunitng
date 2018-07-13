using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using admob;
//using UnityEngine.Advertisements;
//using UnityEngine.Advertisements;
public class pause : MonoBehaviour {
	//public GameObject pauseScreen;
    public static GameObject plyr;
    public static bool istru;
   // public GameObject voice;
    void Start  () {
        istru = false;

        plyr = GameObject.FindGameObjectWithTag("Player");
		}


  	public void PauseButton(){
		GameManager.Instance.PauseDialogue.SetActive (true);

    }
}
