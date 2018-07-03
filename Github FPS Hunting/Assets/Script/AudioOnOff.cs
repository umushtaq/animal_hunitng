using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioOnOff : MonoBehaviour {


//	public GameObject soundOn;
	//public GameObject soundOff;
	private bool muted;



	// Use this for initialization
	void Start () {
		muted = false;
		//soundOff.SetActive (false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	public void SoundMethod()
	{
		if (muted == false) {
		//	soundOn.SetActive (false);
		//	soundOff.SetActive (true);
			muted = true;
			AudioListener.volume = 0;


		} else if (muted == true) {
		//	soundOff.SetActive (false);
		//	soundOn.SetActive (true);
			muted = false;
			AudioListener.volume = 1;

		}
	}
}
