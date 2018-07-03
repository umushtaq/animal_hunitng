using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuSettingManagerScript : MonoBehaviour {

	public GameObject musicSlider;
	public GameObject[] audioSourcesUsed; 

	public GameObject preferenceManager;
	private playerPreferenceManagerScript pPms;

	void Start () 
	{
		pPms = preferenceManager.GetComponent<playerPreferenceManagerScript> ();
		musicSlider.GetComponent<Slider> ().value = pPms.getMusicSensitivity();
		SetvolumeOfAudioSources (pPms.getMusicSensitivity());
	}
	
	// Update is called once per frame

	public void SetmusicValue ()
	{
		float temp = musicSlider.GetComponent<Slider> ().value;
	//	musicSlider.GetComponent<Slider> ().value = temp ;
		pPms.setMusicSensitivity (temp);
		SetvolumeOfAudioSources (temp);
		//Debug.Log ("touch"+temp);
	}
	public void SetvolumeOfAudioSources(float vol)
	{
		for (int i = 0; i < audioSourcesUsed.Length; i++) 
		{
			audioSourcesUsed [i].GetComponent<AudioSource> ().volume = vol;
		}
	}
}
