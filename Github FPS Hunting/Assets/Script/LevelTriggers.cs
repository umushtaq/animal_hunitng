using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelTriggers : MonoBehaviour {

	public static LevelTriggers Instance;
	private int levelvalue;
	public static GameObject plyr;
	public static int totaltarget;
	private int value;
	public Text totaltext;

	void Awake()
	{
		Instance = this;
	}
	void Start()
	{
		levelvalue = PlayerPrefs.GetInt ("Level");
		TotalTarget ();
		totaltarget = 3;
		Debug.Log ("TOtalTarget "+ totaltarget);
		totaltext.text = ""  + totaltarget.ToString ();
	}


	public void Damage()
	{
		Debug.Log ("Entering Value ");
		totaltarget--;
		totaltext.text = "/ "  + totaltarget.ToString ();
		if (totaltarget <= 0) {
			Debug.LogError ("LevelComplete");
		}

	}
	void TotalTarget()
	{

		if (levelvalue == 0 ) 
		{
			totaltarget = 3;
		}
		if (levelvalue == 1) 
		{
			totaltarget = 4;

		}
		if (levelvalue == 2 ) 
		{
			totaltarget = 3;
		
		}
		if (levelvalue == 3 ) 
		{
			totaltarget = 4;

		}
		if (levelvalue == 4) {
			
			totaltarget = 5;

		}
		if (levelvalue == 5 ) 
		{
			totaltarget = 1;

		}
		if (levelvalue == 6 ) 
		{
			totaltarget = 2;

		}
		if (levelvalue == 7 ) 
		{
			totaltarget = 3;

		}
		if (levelvalue == 8 ) 
		{
			totaltarget = 4;

		}
		if (levelvalue == 9 ) 
		{
			totaltarget = 5;

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
			PlayerPrefs.SetInt ("UnlockLevel", 1);
		}
			
	}

}
