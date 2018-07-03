using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

	public AudioClip ClickSound;
	public GameObject Mission;
	public GameObject Mission2;
	public GameObject Mission3;
	public GameObject Mission4;
	public GameObject Mission5;
	public GameObject Mission6;
	public GameObject Mission7;
	public GameObject Mission8;


	private bool AniMission  = false;
	private bool AniMission2 = false;
	private bool AniMission3 = false;
	private bool AniMission4 = false;
	private bool AniMission5 = false;
	private bool AniMission6 = false;
	private bool AniMission7 = false;
	private bool AniMission8 = false;

	void Start(){
		Invoke ("strt",.5f);
	}

	void strt(){
		Debug.Log ("okyy");
		if (!AniMission) {
			activateMission ();
			AniMission = true;
		}
	}


	private void activateMission()
	{
		Mission.GetComponent<Animator> ().SetInteger ("mission", 1);
	}
	private void de_activateMission()
	{
		Mission.GetComponent<Animator> ().SetInteger ("mission", 2);
	}
	private void activateMission2()
	{
		Mission2.GetComponent<Animator> ().SetInteger ("mission2", 1);
	}
	private void de_activateMission2()
	{
		Mission2.GetComponent<Animator> ().SetInteger ("mission2", 2);
	}
	private void activateMission3()
	{
		Mission3.GetComponent<Animator> ().SetInteger ("mission3", 1);
	}
	private void de_activateMission3()
	{
		Mission3.GetComponent<Animator> ().SetInteger ("mission3", 2);
	}
	private void activateMission4()
	{
		Mission4.GetComponent<Animator> ().SetInteger ("mission4", 1);
	}
	private void de_activateMission4()
	{
		Mission4.GetComponent<Animator> ().SetInteger ("mission4", 2);
	}
	private void activateMission5()
	{
		Mission5.GetComponent<Animator> ().SetInteger ("mission5", 1);
	}
	private void de_activateMission5()
	{
		Mission5.GetComponent<Animator> ().SetInteger ("mission5", 2);
	}
	private void activateMission6()
	{
		Mission6.GetComponent<Animator> ().SetInteger ("mission6", 1);
	}
	private void de_activateMission6()
	{
		Mission6.GetComponent<Animator> ().SetInteger ("mission6", 2);
	}
	private void activateMission7()
	{
		Mission7.GetComponent<Animator> ().SetInteger ("mission7", 1);
	}
	private void de_activateMission7()
	{
		Mission7.GetComponent<Animator> ().SetInteger ("mission7", 2);
	}
	private void activateMission8()
	{
		Mission8.GetComponent<Animator> ().SetInteger ("mission8", 1);
	}
	private void de_activateMission8()
	{
		Mission8.GetComponent<Animator> ().SetInteger ("mission8", 2);
	}




	public void MissionChecker()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission) 
		{
			activateMission ();
			AniMission = true;

			if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}


		}
//		else
//		{
//			de_activateMission();
//			AniMission = false;
//		}

	}
	public void MissionChecker2()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission2) 
		{
			activateMission2 ();
			AniMission2 = true;

			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}
				
		}
//		else
//		{
//			de_activateMission2();
//			AniMission2 = false;
//		}

	}
	public void MissionChecker3()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission3) 
		{
			activateMission3 ();
			AniMission3 = true;
			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}
				
		}
//		else
//		{
//			de_activateMission3();
//			AniMission3 = false;
//		}

	}
	public void MissionChecker4()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission4) 
		{
			activateMission4 ();
			AniMission4 = true;

			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}


		}
//		else
//		{
//			de_activateMission4();
//			AniMission4 = false;
//		}

	}
	public void MissionChecker5()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission5) 
		{
			activateMission5 ();
			AniMission5 = true;

			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}

		}
//		else
//		{
//			de_activateMission5();
//			AniMission5 = false;
//		}

	}
	public void MissionChecker6()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission6) 
		{
			activateMission6 ();
			AniMission6 = true;

			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}

		}
//		else
//		{
//			de_activateMission6();
//			AniMission6 = false;
//		}

	}
	public void MissionChecker7()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission7) 
		{
			activateMission7 ();
			AniMission7 = true;
			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission8 == true) {
				de_activateMission8();
				AniMission8 = false;
			}


		}
//		else
//		{
//			de_activateMission7();
//			AniMission7 = false;
//		}

	}
	public void MissionChecker8()
	{
		GetComponent<AudioSource> ().PlayOneShot(ClickSound);
		if (!AniMission8) 
		{
			activateMission8 ();
			AniMission8 = true;

			if (AniMission == true) {
				de_activateMission();
				AniMission = false;
			}if(AniMission2 == true) {
				de_activateMission2();
				AniMission2 = false;
			}if (AniMission3 == true) {
				de_activateMission3();
				AniMission3 = false;
			}if (AniMission4 == true) {
				de_activateMission4();
				AniMission4 = false;
			}if (AniMission5 == true) {
				de_activateMission5();
				AniMission5 = false;
			}if (AniMission6 == true) {
				de_activateMission6();
				AniMission6 = false;
			}if (AniMission7 == true) {
				de_activateMission7();
				AniMission7 = false;
			}


		}
//		else
//		{
//			de_activateMission8();
//			AniMission8 = false;
//		}

	}

}
