using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicVolumeAdjustScript : MonoBehaviour 
{

	public GameObject playerPreference;
	// Use this for initialization
	private playerPreferenceManagerScript pPms;
	void Awake()
	{
		pPms = playerPreference.GetComponent<playerPreferenceManagerScript> ();
		GetComponent<AudioSource> ().volume = pPms.getMusicSensitivity ();
	}
}
