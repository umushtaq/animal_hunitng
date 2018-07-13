using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrol : MonoBehaviour {
	public static animationcontrol instance=null;

	public AudioClip audio;
	public GameObject weaponContainer;
	public int state=1;
	void Awake()
	{
		if (instance == null)
			instance = this;
	}

	void Start ()
	{
		Container ();
	}

	public void WeaponContainerOnOff()
	{
		GetComponent<AudioSource> ().PlayOneShot (audio);
		if (state == 1) 
		{
			state = 2;
			Container ();
		}
		else if (state == 2) 
		{
			state = 1;
			Container ();
		}
	}
	void Container()
	{
		switch(state)
		{
		case 1:
			weaponContainer.SetActive (false);
			break;
		case 2:
			weaponContainer.SetActive (true);
			break;
		}
	}

}
