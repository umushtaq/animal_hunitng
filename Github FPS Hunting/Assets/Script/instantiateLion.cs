using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateLion : MonoBehaviour {

	public static instantiateLion instance;

	public GameObject LionPrefab;
	public float waitTime=3f;
	public Transform[] LionPosition;
	public Transform[][] Array;

	private int levelvalue;
	void Awake()
	{
		instance = this;
	}

	void Start(){
		
		levelvalue = PlayerPrefs.GetInt ("Level");
		bl_HudManager.instance.Huds [levelvalue].Hide = true;
		if (PlayerPrefs.HasKey("FirstTime"))
		{
			Debug.Log ("FleshAwake");
			FleshAwake ();			
		}

	}

	public void FleshAwake()
	{
		Invoke ("Lion",waitTime);
	}

	void Lion()
	{
		bl_HudManager.instance.Huds [levelvalue].Hide = false;
		int value = Random.Range (0,3);
		Instantiate (LionPrefab,LionPosition[value].position,LionPosition[value].rotation);
		bl_HudManager.instance.Huds [levelvalue].m_Target = GameObject.FindGameObjectWithTag("Flesh").transform;
	}


}
