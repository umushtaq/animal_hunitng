using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPreferenceManagerScript : MonoBehaviour {


	public static playerPreferenceManagerScript instance;
	//For Storing Times Played
	private string timesPlayedString = "timesPlayedString";

	//Weapon Menu Selection Index
	private string pistolSelectIndex = "pistolSelectIndex";
	private string heavySelectIndex = "heavySelectIndex";
	private string exHeavySelectIndex = "exHeavySelectIndex";

	//Player Game Data
	private string totalCoins = "totalCoins";
	private string totalGolds = "totalGolds";
	private string totalZombieKill = "totalZombieKill";
	private string totalDeaths = "totalDeaths";
	private string totalScore = "totalScore";


	//Gun Purchase Preference
	private string handGunPurchase = "handGunPurchase";/// 0=lock 1=unlocked
	private string assult1GunPurchase = "assult1GunPurchase"; /// 0=lock 1=unlocked
	private string assult2GunPurchase = "assult2GunPurchase";/// 0=lock 1=unlocked
	private string assult3GunPurchase = "assult3GunPurchase";/// 0=lock 1=unlocked


	private string InputType="InputType"; //0=GYRO ,1=TOUCH , 2=SYSTEM

	private string TouchSensitivity = "TouchSensitivity";
	private string GyroSensitivity = "GyroSensitivity";
	private string MusicSensitivity = "MusicSensitivity";
	private string SoundSensitivity = "SoundSensitivity";


	void Awake()
	{
		if (instance == null) {
			instance = this;
		}
	//	PlayerPrefs.DeleteAll ();
		if (GetTimesPLayed () == 0 && GetTotalCoins()==0)
		{
			//SetTotalCoins(25);
			SetheavySelectIndex (0);//0,1
			SetpistolSelectIndex (0);//0,1,2,3
			SetexHeavySelectIndex (1);//0=off,1=active
			setMusicSensitivity(1f);
			setInput(2);
		}
	}


	public void setInput(int input)
	{
		PlayerPrefs.SetInt (InputType, input);
	}
	public int getInput()
	{
		return PlayerPrefs.GetInt (InputType);
	}
	// TotalCoins Played Setter and Getter
	public void SetTotalCoins(int a)
	{
		PlayerPrefs.SetInt (totalCoins, GetTotalCoins()+a);
		SetTotalScore (a);
	}
	public int GetTotalCoins()
	{
		return PlayerPrefs.GetInt(totalCoins);
	}

	public void SetTotalGolds(int a){
		PlayerPrefs.SetInt (totalGolds,GetTotalGolds()+a);
	}
	public int GetTotalGolds(){
		return PlayerPrefs.GetInt (totalGolds);
	} 

	// TotalZombieKill Setter and Getter
	public void SetTotalZombieKill(int a)
	{
		PlayerPrefs.SetInt (totalZombieKill, GetTotalZombieKill()+a);//GetTotalZombieKill()
	}
	public int GetTotalZombieKill()
	{
		
		return PlayerPrefs.GetInt(totalZombieKill);
	}

	// totalDeaths Played Setter and Getter
	public void SetTotalDeaths(int a)
	{
		PlayerPrefs.SetInt (totalDeaths, GetTotalDeaths()+a);
	}
	public int GetTotalDeaths()
	{
		return PlayerPrefs.GetInt(totalDeaths);
	}

	// totalScore Setter and Getter
	public void SetTotalScore(int a)
	{
		PlayerPrefs.SetInt (totalScore, GetTotalScore()+a);
	}
	public int GetTotalScore()
	{
		return PlayerPrefs.GetInt(totalScore);
	}

	/// <summary>
	/// 
	/// </summary>
	// Times Played Setter and Getter
	public void SetTimesPlayed()
	{
		PlayerPrefs.SetInt (timesPlayedString, GetTimesPLayed()+1);
	}
	public int GetTimesPLayed()
	{
		return PlayerPrefs.GetInt(timesPlayedString);
	}

	// pistolSelectIndex Played Setter and Getter
	public void SetpistolSelectIndex(int a)
	{
		PlayerPrefs.SetInt (pistolSelectIndex, a);
	}
	public int GetpistolSelectIndex()
	{
		return PlayerPrefs.GetInt(pistolSelectIndex);
	}

	// heavySelectIndex Played Setter and Getter
	public void SetheavySelectIndex(int a)
	{
		PlayerPrefs.SetInt (heavySelectIndex, a);
	}
	public int GetheavySelectIndex()
	{
		return PlayerPrefs.GetInt(heavySelectIndex);
	}

	// exHeavySelectIndex Played Setter and Getter
	public void SetexHeavySelectIndex(int a)
	{
		PlayerPrefs.SetInt (exHeavySelectIndex, a);
	}
	public int GetexHeavySelectIndex()
	{
		return PlayerPrefs.GetInt(exHeavySelectIndex);
	}
		

	/// Gun Purchase Setters and Getters
	public void setHandGunPurchase(int input)
	{
		PlayerPrefs.SetInt (handGunPurchase, input);
	}
	public int getHandGunPurchase()
	{
		return PlayerPrefs.GetInt (handGunPurchase);
	}
	public void setAssult1GunPurchase(int input)
	{
		PlayerPrefs.SetInt (assult1GunPurchase, input);
	}
	public int getAssult1GunPurchase()
	{
		return PlayerPrefs.GetInt (assult1GunPurchase);
	}
	public void setAssult2GunPurchase(int input)
	{
		PlayerPrefs.SetInt (assult2GunPurchase, input);
	}
	public int getAssult2GunPurchase()
	{
		return PlayerPrefs.GetInt (assult2GunPurchase);
	}
	public void setAssult3GunPurchase(int input)
	{
		PlayerPrefs.SetInt (assult3GunPurchase, input);
	}
	public int getAssult3GunPurchase()
	{
		return PlayerPrefs.GetInt (assult3GunPurchase);
	}

	//// Rotation and Gyro Sensitivity pref

	public void setTouchSensitivity(int input)
	{
		PlayerPrefs.SetInt (TouchSensitivity, input);
	}
	public int getTouchSensitivity()
	{
		return PlayerPrefs.GetInt (TouchSensitivity);
	}
	public void setGyroSensitivity(int input)
	{
		PlayerPrefs.SetInt (GyroSensitivity, input);
	}
	public int getGyroSensitivity()
	{
		return PlayerPrefs.GetInt (GyroSensitivity);
	}

	///music volume
	public void setMusicSensitivity(float input)
	{
		PlayerPrefs.SetFloat (MusicSensitivity, input);
	}
	public float getMusicSensitivity()
	{
		return PlayerPrefs.GetFloat (MusicSensitivity);
	}

	public void setSoundSensitivity(float input)
	{
		PlayerPrefs.SetFloat (SoundSensitivity, input);
	}
	public float getSoundSensitivity()
	{
		return PlayerPrefs.GetFloat (SoundSensitivity);
	}


}
