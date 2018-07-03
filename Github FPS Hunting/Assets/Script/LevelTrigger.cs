using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelTrigger : MonoBehaviour {

	public static LevelTrigger instance=null;
	private int target;
	public int Currenttarget=0;
	private int levelvalue;
	public static int lessSoldier;
	public static GameObject plyr;
	public Text Die;
	public Text Total;
	public GameObject LevelComplete;

	void Awake(){
		if (instance == null) {
			instance = this;
		}
	}

	void Start()
	{
		levelvalue = PlayerPrefs.GetInt ("Level");
		SetTarget ();

	}
	void FixedUpdate()
	{
		Currenttarget= CharacterDamage.Soldierdie;
		Die.text = " " + Currenttarget.ToString ();
		Total.text = " " + "/  " + target.ToString ();

		if (lessSoldier <= 0) {
			Invoke ("ShowCompletePanel",2f);
		}
	}

	void ShowCompletePanel(){
		LevelTrigger.instance.LevelComplete.SetActive (true);
		CharacterDamage.Soldierdie = 0;
		LevelTrigger.instance.UnlockLevel ();
		Debug.Log ("Completepanelll");
		Time.timeScale = 0;
	}

//	public void ShowFailedPanel(){
//		Invoke ("failed",2f);
//	}
//	public void failed(){
//		FPSPlayer.instance.GameOverPanel.SetActive (true);
//	//	Time.timeScale = 0.0f;
//	}

	void SetTarget()
	{
		
		if (levelvalue == 0 ) 
		{
			target = 5;
			lessSoldier = 5;
		}
		if (levelvalue == 1) 
		{
			target = 7;
			lessSoldier = 7;
		}
		if (levelvalue == 2 ) 
		{
			target = 9;
			lessSoldier = 9;
		}
		if (levelvalue == 3 ) 
		{
			target = 11;
			lessSoldier = 11;
		}
		if (levelvalue == 4) {

			target = 13;
			lessSoldier = 13;
		}
		if (levelvalue == 5 ) 
		{
			target = 15;
			lessSoldier = 15;
		}
		if (levelvalue == 6 ) 
		{
			target = 17;
			lessSoldier = 17;
		}
		if (levelvalue == 7 ) 
		{
			target = 20;
			lessSoldier = 20;
		}
		
	}
	public void UnlockLevel()
	{
		
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
			
	}

}
