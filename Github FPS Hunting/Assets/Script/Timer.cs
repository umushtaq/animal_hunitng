using System.Collections.Generic;
using UnityEngine;
using System.Collections;

using UnityEngine.UI;
public class Timer : MonoBehaviour {
	
	public float myTime;
	public Text timertxt;
	int addd;
	public static GameObject timer;
	// Use this for initialization
	void Start () {
		timer = GameObject.FindGameObjectWithTag("timer");
		addd = 0;
		myTime = GameManager.Instance.timervalue;
		print ("my time "+ myTime);

	}
	void Update () {
		
		TimerFunction ();
	}
		
	void TimerFunction()
	{
		int minutes = (int)myTime / 60;
		int second = (int)myTime % 60;
		timertxt.text = minutes.ToString()+" : " + second.ToString();
		myTime = myTime - Time.deltaTime;
		if (myTime <= 0) {
			GameManager.Instance.gameOverDialogue.SetActive (true);
			timertxt.text = "00"+" : " + "00";
			Time.timeScale = 0;
			if (addd == 0) {
				//Add Ads hERE
				addd = 1;
			}

		} else 
		{
			if (minutes <= 9) {
				if (second <= 9) 
				{
					timertxt.text = "0" + minutes.ToString () + " : 0" + second.ToString ();
				} else
				{
					timertxt.text = "0" + minutes.ToString () + " : " + second.ToString ();
				}
			} else 
			{
				if (second <= 9) 
				{
					timertxt.text = "" + minutes.ToString () + " : 0" + second.ToString ();
				} else
				{
					timertxt.text = "" + minutes.ToString () + " : " + second.ToString ();
				}
			}
				
		}

	}

}