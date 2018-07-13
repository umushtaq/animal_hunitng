using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotalKilledImages : MonoBehaviour {

	public Sprite[] totalKilled;
	private int levelvalue;
	// Use this for initialization
	void Start () {
		levelvalue = PlayerPrefs.GetInt ("Level");
		TotalKillAnimalSprite ();
	}

	void TotalKillAnimalSprite ()
	{
		if (levelvalue == 0 || levelvalue == 2) 
		{
			GetComponent<Image> ().sprite = totalKilled [0];
		}
		if (levelvalue == 1 || levelvalue == 3) 
		{
			GetComponent<Image> ().sprite = totalKilled [1];
		}
		if (levelvalue == 4 || levelvalue == 6) 
		{
			GetComponent<Image> ().sprite = totalKilled [2];
		}
		if (levelvalue == 5 || levelvalue == 7) 
		{
			GetComponent<Image> ().sprite = totalKilled [3];
		}
			
	}

}
